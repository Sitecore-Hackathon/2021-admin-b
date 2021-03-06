# escape=`

ARG PARENT_IMAGE
ARG SOLUTION_IMAGE
ARG JSS_IMAGE
ARG SPE_IMAGE
ARG TOOLS_IMAGE

FROM ${SOLUTION_IMAGE} as solution
FROM ${TOOLS_IMAGE} as tools
FROM ${SPE_IMAGE} as spe
FROM ${JSS_IMAGE} as jss
FROM ${PARENT_IMAGE}

SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop'; $ProgressPreference = 'SilentlyContinue';"]

WORKDIR C:\build
ARG NODEJS_VERSION
RUN Invoke-WebRequest -OutFile nodejs.zip -UseBasicParsing "https://nodejs.org/dist/v$env:NODEJS_VERSION/node-v$env:NODEJS_VERSION-win-x64.zip"; `
    Expand-Archive nodejs.zip -DestinationPath C:\; `
    Rename-Item "c:\\node-v$env:NODEJS_VERSION-win-x64" c:\nodejs; `
    setx /M PATH $($Env:PATH + ';C:\nodejs'); `
    Remove-Item -Path nodejs.zip -Force;

# Copy development tools and entrypoint
COPY --from=tools \tools\ \tools\

WORKDIR C:\inetpub\wwwroot

# Add SPE module
COPY --from=spe \module\cm\content .\

# Add JSS module
COPY --from=jss \module\cm\content .\
COPY --from=jss \module\tools \module\tools
RUN C:\module\tools\Initialize-Content.ps1 -TargetPath .\; `
    Remove-Item -Path C:\module -Recurse -Force;

# Copy solution website files
COPY --from=solution /artifacts/platform/ ./
