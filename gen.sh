#!/usr/bin/env bash
rm -r src/Quali.Torque.Api
~/bin/openapitools/openapi-generator-cli generate \
-g aspnetcore \
-i torque-api-spec.json \
--skip-validate-spec \
-c generator-config.yaml \
