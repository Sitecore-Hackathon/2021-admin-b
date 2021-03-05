![Hackathon Logo](docs/images/hackathon.png?raw=true "Hackathon Logo")
# Sitecore Hackathon 2021

- MUST READ: **[Submission requirements](SUBMISSION_REQUIREMENTS.md)**
- [Entry form template](ENTRYFORM.md)
- [Starter kit instructions](STARTERKIT_INSTRUCTIONS.md)
  
  
### Hello AdminB!

Updated for 10.1!  Just so Adam can see those cool icons: https://velir.slack.com/archives/CSZGR0Q3T/p1614910430012400

(And so we dont' get disqualified....)

If you've had this running before, make sure to run

    cd docker
    .\clean.ps1

This will get rid of all the 10.0.1 gooey bits that would gum up 10.1.

Also, I've been running into some memory issues (sign of being near 60), so I've put these settings in a **.env.user** file

    # Container memory limits
    MEM_LIMIT_SQL=300MB
    MEM_LIMIT_CM=300MB
    MEM_LIMIT_SOLR=300MB
    MEM_LIMIT_ROLES=300MB

Erica, since you are on 2004, you can set your fancy
    
    SITECORE_VERSION=10.1.0-2004
    ISOLATION=hyperv

settings in your .env.user file.  (Actually you may be able to switch to ISOLATION=process to get your environment to _rip_. See this: https://velir.slack.com/archives/CMUK8EG0Y/p1614884238030700?thread_ts=1614008156.004000&cid=CMUK8EG0Y though )

### ⟹ [Insert your documentation here](ENTRYFORM.md) <<