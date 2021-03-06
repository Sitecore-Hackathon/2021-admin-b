![Hackathon Logo](docs/images/hackathon.png?raw=true "Hackathon Logo")
# Sitecore Hackathon 2021

- MUST READ: **[Submission requirements](SUBMISSION_REQUIREMENTS.md)**
- [Entry form template](ENTRYFORM.md)
- [Starter kit instructions](STARTERKIT_INSTRUCTIONS.md)
  
  
### Admin/B Team Instructions


#### 10.1

If you've had this running before, make sure to run

    cd docker
    .\clean.ps1

Also, you may want to use these settings in **docker\.env.user** if images are randomly becoming unhealthy. 

    # Container memory limits
    MEM_LIMIT_SQL=300MB
    MEM_LIMIT_CM=300MB
    MEM_LIMIT_SOLR=300MB
    MEM_LIMIT_ROLES=300MB

This file can all be used to set images and isolation to match OS settings.
    
    SITECORE_VERSION=10.1.0-2004
    ISOLATION=process
 
#### Build
Buidling can be done by deploying the Website\HPP project.  This will deploy all projects to the CM and CD images, via the **docker\deploy\project** folder. If new modules are added, they should be added as refernces to the HPP project.

#### TO DO
Set up Sitecore CLI, serialization.
Set up sample content (e.g from Helix Examples.)

### ⟹ [Insert your documentation here](ENTRYFORM.md) <<