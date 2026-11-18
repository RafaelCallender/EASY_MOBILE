#!/usr/bin/env bash
set -euo pipefail

script_dir="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
android_sdk_root="${ANDROID_SDK_ROOT:-${ANDROID_HOME:-$HOME/Android/Sdk}}"
ndk_version="26.3.11579264"
cmake_version="3.22.1"
ndk_root="${ANDROID_NDK_HOME:-$android_sdk_root/ndk/$ndk_version}"
cmake="$android_sdk_root/cmake/$cmake_version/bin/cmake"
source_dir="$script_dir/obj/llama.cpp-73c9eb8ceda397b651dbb6661b2935f0283a2b1d"
build_dir="$script_dir/obj/android-armv8-backend"
native_dir="$script_dir/Platforms/Android/jniLibs/arm64-v8a"
llama_commit="73c9eb8ceda397b651dbb6661b2935f0283a2b1d"

if [[ ! -x "$cmake" ]]; then
    echo "Android CMake $cmake_version was not found at $cmake." >&2
    exit 1
fi

if [[ ! -f "$ndk_root/build/cmake/android.toolchain.cmake" ]]; then
    echo "Android NDK $ndk_version was not found at $ndk_root." >&2
    exit 1
fi

if [[ ! -d "$source_dir/.git" ]]; then
    git clone --filter=blob:none --no-checkout \
        https://github.com/ggerganov/llama.cpp.git "$source_dir"
fi

git -C "$source_dir" fetch --depth=1 origin "$llama_commit"
git -C "$source_dir" checkout --detach "$llama_commit"

"$cmake" -S "$source_dir" -B "$build_dir" \
    -DCMAKE_TOOLCHAIN_FILE="$ndk_root/build/cmake/android.toolchain.cmake" \
    -DANDROID_ABI=arm64-v8a \
    -DANDROID_PLATFORM=android-23 \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_C_FLAGS=-march=armv8-a \
    -DCMAKE_CXX_FLAGS=-march=armv8-a \
    -DGGML_NATIVE=OFF \
    -DGGML_CPU_AARCH64=ON \
    -DGGML_CPU_ARM_ARCH=armv8-a \
    -DGGML_OPENMP=OFF \
    -DGGML_LLAMAFILE=OFF \
    -DLLAMA_OPENSSL=OFF \
    -DLLAMA_BUILD_SERVER=OFF \
    -DLLAMA_BUILD_TESTS=OFF \
    -DLLAMA_BUILD_TOOLS=ON \
    -DLLAMA_BUILD_EXAMPLES=OFF \
    -DLLAMA_BUILD_COMMON=ON

"$cmake" --build "$build_dir" --target llama mtmd --config Release \
    --parallel "${CMAKE_BUILD_PARALLEL_LEVEL:-2}"

mkdir -p "$native_dir"
cp "$build_dir/bin/libggml-base.so" \
    "$build_dir/bin/libggml-cpu.so" \
    "$build_dir/bin/libggml.so" \
    "$build_dir/bin/libllama.so" \
    "$build_dir/bin/libmtmd.so" \
    "$native_dir/"

echo "Installed ARMv8-A Android native libraries in $native_dir"
