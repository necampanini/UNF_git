# UNF_git
Sample Project for outlining and demonstrating Git version control to senior project class of 2015/16.

- Initial version will be basic static site. HTML, CSS, bit of javascript.
- The purpose of this project is to have something tangible for students to interact with.
- Ideally the feedback is immediate and students leave with experience they did not have before.

## Team based approach
We'll be breaking into 3-person teams.

# Step-by-General-Step

## Step 0

- https://github.com/ Make an account, email, password, username
- free plan, unless you want to start paying right out of the gate. 

## Step 1 

#### Install Git on your OS of choice
- Windows: http://git-scm.com/download/win
- Mac: http://git-scm.com/download/mac
- Linux: Depending on your distribution of choice
	* `
	$ sudo yum install git
	`
	* `
	$ sudo apt-get install git
	`

* Assuming windows:
- Leave default components 
- Ensure Git Bash Here is checked
- Use Git from Git Bash only
- Windows style - unix style line endings
- windows key - Git .exe


## Step 2

#### Getting Started - First-Time Git Setup

- open Git Bash.exe
- this opens up a command line
- should default be USER@PC_NAME
- type ls -la (elle ess, dash elle A)
- mkdir gitDemo -- make directory
- cd gitDemo -- change directory
- cd ..
- cd gitDemo
- git init
- ls -la
- cd .. back up
- cd /c/
- mkdir Projects
- cd Projects
- https://github.com/necampanini/UNF_git

- right hand side, under HTTPS git clone URL
- copy
- in gitbash, type: git clone [URL] here, INS key works most of the time
- this CLONES the repo
- CLONES and makes your own local version of this repository
- cd into newly made folder, should now see (master)
- git branch, should see list of branches
- git checkout -b team/feature_01 - EXPLAIN WHAT ALL IS
- git branch again
- make new file, doesnt matter, but make sure its in UNF_git folder, save
- git status
- explain untracked, modified, staged etc
- if onle file, can "git add [tab]"
- git status
- is now green, 

- go back to new file, change it in some way, and save
- git status

- make another new files, change, save
- git status

- git add one of those files.
- git status to see green and red

- explain stuff, staging what its tracking
- git commit -m "i am rexxar, lord of terror"

- inside repository
- git config --global user.name "John Doe"
- git config --global user.email "johndoe@example.com"

- explain first parts, branch name and GUID

- git status
- git log

- should see your commit! 
- and all previous 

- press spacebar to continuing paging through the log
- or press q to quit out

- git push [origin] [branchname]
- if newly created branch, have to specify upstream and new branch name

- it will ask for credentials
- github email
- your password **THIS WILL BE EMPTY AND APPEAR TO NOT HAVE ANYTHING**

- refresh github page
- dropdown into new branch

- see new branch. new files!

- walk through pull request
- right hand side; pull requests
- new pull request
- 2 drop down buttons, base: and compare:
- explain base and compare
- able to merge!

- explain green/red
- click create pr

- refersh page, should see new prs!
- click into that pull request

- discuss etc
- able to merge? merge
- delete

- go back homepage
- cool!

- your repository is now different
- (git reset --hard if necessary)

- switch to master branch
- git pull

- new stuff in master now that wasn't there before
- git pull

- in sample file, you guys change something
- git status
- git add [tab]
- git commit -m "changed exxar"

- git pull a change will resolve in merge conflict

- merging || how resolve
- 



