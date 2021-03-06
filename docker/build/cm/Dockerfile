# escape=`

ARG PARENT_IMAGE
ARG SOLUTION_IMAGE
ARG TOOLS_IMAGE
ARG SPE_IMAGE
ARG HEADLESS_IMAGE
ARG MGMT_IMAGE

# FROM ${SOLUTION_IMAGE} as solution
FROM ${TOOLS_IMAGE} as tools
FROM ${SPE_IMAGE} as spe
FROM ${HEADLESS_IMAGE} as headless
FROM ${MGMT_IMAGE} as mgmt

FROM ${PARENT_IMAGE}


SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop'; $ProgressPreference = 'SilentlyContinue';"]


# Copy developer tools and entrypoint
COPY --from=tools C:\tools C:\tools


WORKDIR C:\inetpub\wwwroot


# Add SPE module
COPY --from=spe \module\cm\content .\ 
COPY --from=headless \module\cm\content .\
COPY --from=mgmt \module\cm\content .\

# Copy solution website files
# COPY --from=solution /artifacts/platform/ ./  TODO FIX