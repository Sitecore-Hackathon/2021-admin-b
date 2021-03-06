![Hackathon Logo](docs/images/hackathon.png?raw=true "Hackathon Logo")

## Team name
admin/b

## Category
Best use of Headless using JSS or .NET

## Description
Our project, **Headless in Hollywood**, is a movie recommendation website that showcases multiple advanced Sitecore features including: containerized deployment, content serialization, headless serving of content, xDB tracking, and personalization. End-users are encouraged to pick a few of their favorite movies from a list of IMDB's top 1000 movies. Using Sitecore behavioral profiling, the user's preferred movie genres can be inffered and used to power a personalized banner at the top of the site. This entire experience requires onlyl a single page load.


- Additional notes?
  - Module Purpose
  - What problem was solved (if any)
  - How does this module solve it

## Video link
⟹ Provide a video highlighing your Hackathon module submission and provide a link to the video. You can use any video hosting, file share or even upload the video to this repository. _Just remember to update the link below_

⟹ [Replace this Video link](#video-link)

## Pre-requisites and Dependencies

Our project builds off of the Sitecore "Getting Started" Docker template which means that all pre-requisites for that project also apply to our project. [Starter kit (https://doc.sitecore.com/developers/100/developer-tools/en/walkthrough--using-the-getting-started-template.html)

- Docker must be installed and set to use Windows containers. [See documentation for Docker Desktop](https://docs.docker.com/docker-for-windows/#switch-between-windows-and-linux-containers) 
- Windows must be configured with the HyperV and Containers features as described in [Docker System Requirements](https://docs.docker.com/docker-for-windows/install/#system-requirements). [Enabling HyperV](https://docs.microsoft.com/en-us/virtualization/hyper-v-on-windows/quick-start/enable-hyper-v). 
- A valid Sitecore license.xml file must be available in \docker\License
- Multiple ports will be used by the various containers. Please stop any existing containers and/or applications that might cause conflicts prior to starting our project.

⟹ Does your module rely on other Sitecore modules or frameworks?

- List any dependencies
- Or other modules that must be installed
- Or services that must be enabled/configured

## Installation instructions
⟹ Write a short clear step-wise instruction on how to install your module.  

    
1. Rename \docker\env.user.sample to \docker\env.user to apply recommended memory settings. 

    ```
    MEM_LIMIT_SQL=300MB
    MEM_LIMIT_CM=300MB
    MEM_LIMIT_SOLR=300MB
    MEM_LIMIT_ROLES=300MB
    MEM_LIMIT_XDBSEARCH=1GB
    ```
This file can also be used to set images and isolation to match OS settings.

    SITECORE_VERSION=10.1.0-2004
    ISOLATION=process

2. Open the root folder using PowerShell with elevated access
3. Start Docker containers using `.\Start-Hackathon.ps1`. This will restore the Sitecore.CLI items, deserialize and publish. If any containers fail due to unhealthy dependencies, try waiting 60 seconds and running `.\Start-Hackathon.ps1` once more to ensure require resources are available. 
4. ?? Open solution in Visual Studio and run build
...
5. Navigate to https://cm.hack.localhost/sitecore and log in with admin/b 

If you restart these steps, be sure to run this first:

    cd docker
    .\clean.ps1


### Configuration
⟹ If there are any custom configuration that has to be set manually then remember to add all details here.

_Remove this subsection if your entry does not require any configuration that is not fully covered in the installation instructions already_

## Usage instructions
⟹ Provide documentation about your module, how do the users use your module, where are things located, what do the icons mean, are there any secret shortcuts etc.

### Content Author Experience
1. Navigate to https://cm.hack.localhost/sitecore and login with admin/b
2. Select the experience editor
3. Select the top banner component and click the "Personalization" button
4. Review the personalization conditions. Each condition takes a profiled 'Genre' as an input and provides a movie data source as an output. 
5. Publish changes, if any.

### End User Experience

1. Navigate to https://cd.hack.localhost/
2. Select up to 5 different movies (TODO: provide some concrete examples)
3. Confirm that the top banner has updated with a recommendation matching your genre preferences

TODO: screenshots. 

## Comments
⟹ If you'd like to make additional comments that is important for your module entry.

## TO DO List

1. MSBUILD is commented out in solution Dockerfile, due to a build error. Fix this.  Workaround: publish HPP project manually.

# Submission Requirements
- MUST READ: **[Submission requirements](SUBMISSION_REQUIREMENTS.md)**
- [Entry form template](ENTRYFORM.md)
 
