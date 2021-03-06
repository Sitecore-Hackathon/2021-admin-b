# escape=`

ARG PARENT_IMAGE
ARG SOLUTION_IMAGE
ARG TOOLS_IMAGE
ARG SPE_IMAGE
ARG CET_IMAGE
ARG HEADLESS_IMAGE
ARG MGMT_IMAGE

# FROM ${SOLUTION_IMAGE} as solution
FROM ${TOOLS_IMAGE} as tools
FROM ${SPE_IMAGE} as spe
FROM ${CET_IMAGE} as cet
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


# Add CET module
COPY --from=cet \module\cm\content .\	
 
RUN `
     move-item -Path App_Config\sitecore\Services.GraphQL\sitecore.services.graphql.content.core.config.example -Destination App_Config\sitecore\Services.GraphQL\sitecore.services.graphql.content.core.config; `
     move-item -Path App_Config\sitecore\Services.GraphQL\sitecore.services.graphql.content.master.config.example  -Destination  App_Config\sitecore\Services.GraphQL\sitecore.services.graphql.content.master.config; `
     move-item -Path App_Config\sitecore\Services.GraphQL\sitecore.services.graphql.content.web.config.example  -Destination  App_Config\sitecore\Services.GraphQL\sitecore.services.graphql.content.web.config

# Copy solution website files
# COPY --from=solution /artifacts/platform/ ./  TODO FIX