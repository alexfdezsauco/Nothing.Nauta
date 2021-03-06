# Nothing.Nauta

[![Build Status](https://dev.azure.com/alexfdezsauco/Nothing.Nauta/_apis/build/status/alexfdezsauco.Nothing.Nauta?branchName=develop)](https://dev.azure.com/alexfdezsauco/Nothing.Nauta/_build/latest?definitionId=1&branchName=develop)

The ultimate DotNet API to manage ETECSA Nauta sessions

# Nothing.Nauta Example Applications

## nauta-session

nauta-session is command line tool to manage ETECSA nauta sessions. 

### Usage

  nauta-session [command] [options]
  
### Commands

#### Save Credentials

To save credentials use the `credentials` command as follow:

    > nauta-session credentials --username %USERNAME% --password %PASSWORD%

Actually, it is also possible save multiple credentials with alias: 

    > nauta-session credentials --username %USERNAME% --password %PASSWORD% --alias %ALIAS%

    
#### Open Nauta Session

To open a nauta session use the `open` command as follow:

    > nauta-session open

In order to open a session with credentials saved with an alias you could use a command as follow:

    > nauta-session --alias %ALIAS%


#### Query Remaining Time From Nauta Session

To query remaining time from the nauta session use the `time` command as follow:

    > nauta-session time
    
#### Close Nauta Session

To close a nauta session use the `close` command as follow:

    > nauta-session close
