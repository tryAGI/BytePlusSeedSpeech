#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace BytePlusSeedSpeech \
  --clientClassName BytePlusSeedSpeechClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme ApiKey:Header:X-Api-Key \
  --exclude-deprecated-operations
