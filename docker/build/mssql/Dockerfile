# escape=`

ARG PARENT_IMAGE
ARG SPE_IMAGE
ARG CET_IMAGE

FROM ${SPE_IMAGE} as spe
FROM ${CET_IMAGE} as cet
FROM ${PARENT_IMAGE}


SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop'; $ProgressPreference = 'SilentlyContinue';"]

# Add SPE module
COPY --from=spe \module\db \spe_data
RUN C:\DeployDatabases.ps1 -ResourcesDirectory C:\spe_data; `
    Remove-Item -Path C:\spe_data -Recurse -Force;
	
# Add CET module
COPY --from=cet \module\db \cet_data
RUN C:\DeployDatabases.ps1 -ResourcesDirectory C:\cet_data; `
    Remove-Item -Path C:\cet_data -Recurse -Force;