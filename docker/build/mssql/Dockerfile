# escape=`

ARG PARENT_IMAGE
ARG SPE_IMAGE
ARG HEADLESS_IMAGE
ARG CET_IMAGE

FROM ${SPE_IMAGE} as spe
FROM ${HEADLESS_IMAGE} as headless
FROM ${CET_IMAGE} as cet

FROM ${PARENT_IMAGE}

SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop'; $ProgressPreference = 'SilentlyContinue';"]

# Add modules
COPY --from=spe \module\db \spe_data

COPY --from=headless \module\db \headless_data

# Add CET module
COPY --from=cet \module\db \cet_data
RUN C:\DeployDatabases.ps1 -ResourcesDirectory C:\cet_data; `
    Remove-Item -Path C:\cet_data -Recurse -Force;


RUN C:\DeployDatabases.ps1 -ResourcesDirectory C:\spe_data; `
    Remove-Item -Path C:\spe_data -Recurse -Force;

RUN C:\DeployDatabases.ps1 -ResourcesDirectory C:\headless_data; `
    Remove-Item -Path C:\headless_data -Recurse -Force;
