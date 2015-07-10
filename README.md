# UNF_git
Sample Project for outlining and demonstrating Git version control to senior project class of 2015/16.

- Initial version will be basic static site. HTML, CSS, bit of javascript.
- The purpose of this project is to have something tangible for students to interact with.
- Ideally the feedback is immediate and students leave with experience they did not have before.

## The branch 'develop' is what I will be working from in creating this, so watch for the README here on this branch.

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
- Make sure these options are checked:
* Ensure Git Bash is checked
* On next screen Use Git from Git Bash only


## Step 2

#### Getting Started - Discovering the Command Line

- open Git Bash.exe
- this opens up a command line
- should default be USER@PC_NAME
- type ls -la (elle ess, dash elle A)
- look at all the things.

#### Git Global Config

- In Git Bash, type:
```
git config --global user.name "John Doe"
git config --global user.email "johndoe@example.com"
```

#### Getting Started - Creating a work place

- ASSUMING WINDOWS: type the following:

```
cd /c/
```
```
mkdir Projects
cd Projects
mkdir Demo_01
cd Demo_01
```

##### In order, you did the following actions:
- Change to your C:\ directory.
- Then, you made a new directory(s) within C:\ named Projects.
- You then Changed Directory, into said new directory(s)

#### Git Commands

- Make sure you are in the Projects/Demo_01 directory.
- After each command, read what is displayed. Carefully.
- Now type in GitBash:

```
git init
git status
ls -la
```

- The first two commands are git specific commands, where you initialized a git repository, and checked on its current status
- ls -la is a unix command that works in this program (Git Bash). You list the current working directory's contents
- with the "-la" options, you list contents in a list format and include ALL files, even hidden files and directories.

#### Git Commands - The Connecting

This should all look familiar if you have been doing your homework. Or, if you jumped into this first, you will get plenty of reinforcement later on.

Now, we get to pull down this project!

##### WARNING: make sure you are back /c/Projects/ before continuing.
- Navigate to: https://github.com/necampanini/UNF_git
- On the right hand side, under where it says "HTTPS git clone URL"
- Copy this URL.
- This is the actual repository you will pull down.

#### Git Commands - The Cloning

- In Git Bash, type:
```
git clone https://github.com/necampanini/UNF_git.git
```
- The INS key works for pasting things into Git Bash.
- This CLONES the repo. All current data and all the history associated that has been commited to it thus far.
- This process creates your own local version of this repository. Everyone can have their local version! Crazy!

#### Git Commands - The Discovering

- With the repository pulled down (cloned), you should see a new folder if you type "ls -la" in Git Bash
- Change into this new directory (remember how?)
- You should see a new word in Git Bash: (master) next to your current working directory.
- This is the name of your current working BRANCH.

#### Git Branches - Even More Cloning?

- Essentially, branches are again, local copies of code.
- They allow you to work on editing your code in a seperate, contained fashion.
- Branches can branch off each other endlessly (or until memory cap is hit)
- Type the following to start to get a look around:
```
git branch
```
- This should list out the branches that this repository had at the time of cloning.
- Now, try creating your own branch:
#####Replace 'your_name' with your name :)
```
git checkout -b demo/your_name
```

- The 'checkout -b' is a combined command of "checking out" a newly created branch.
- There is often naming conventions for branches. They vary, so adapt early and often.

#### Tracking Files - Disappearing Act

- Type "git branch" to list out the current branches.
- One will have a asterisk next to it (and possibly be colored in).
- This indicates the branch you are currently working in.

- Making sure you are in this test branch. Create a new text file named "the_demo" anywhere inside our repo. Save it.
- Type git status

- New text should appear. Git will notify you of new files it detects but isn't currently "tracking"
- New files will appear as "Untracked"
- Existing files that have had changes applied to them since last commit, appear as "Modified"
- Files that are ready to be commited (through your intervention), will appear as "Staged"
- Files not added to the Staging list, will not be included when you "Commit".
- These concepts essentially define how Git works. Get lots of practice to understand it.

#### Git Add - Soon To Commit

- Type:
```
git add the_demo
git status
```
- You've now added this new file to git's tracking. That ADDITION is ready to be commited.
- Edit this file in some way. Add a line, change some text. Whatever.
- git status
- You should see that on top of adding a file to be tracked, git tracks changes in that file
- However, those new changes are not STAGED for a COMMIT.

#### Git Commit - There's no turning back now (yes there is)

- Type:
```
git add the_demo
git commit -m "I am a commit message"
git status
git log
```
- Harken back to Comp Structures (the best class)
- Imagine a Directed Acyclic Graph

- Each time you "commit", you tell Git to save the changes you've made. Quite literally.
- Git works in such a way that if keeps track of deltas through out a DAG (directed acyclic graph)
- You should see your latest commit and the commit message at the top of the output from "git status"

#### Git Log

- Press spacebar to page through the output, or down arrow.
- Press "Q" to quit out of the log.
- There are nice GUIs to help visualize these DAGs, but for now, we're staying with the command line.

#### Git Push

- Now that we have a new branch, and new changes, we want our ORIGIN repository to have those changes.
##### replace [branchname] with whatever branch you want to add to our remote repository. In this case it should be demo/your_name
```
git push --set-upstream origin [branchname]
```
- If this is a newly created branch (which it is), we'll have to specify upstream and the new branch name.
- We do this with the "--set-upstream", telling git this is the branch we want to keep track of.

- Git will ask for credentials
- Enter your github email/username and password
- **In typing your password, nothing will appear, don't worry.**

#### GitHub

- Navigate to https://github.com/necampanini/UNF_git
- Click on the Branch dropdown and find your newly pushed-up branch!
- Observe new branch. Observe new files!

#### Merging And Pull Requests

- Back in Git Bash, if you want to merge new code/features/work into other branches, you can.
- With the changes you've made to your demo branch, let's merge those changes in to the branch "merge/into/me"

```
git checkout merge/into/me
git merge demo/your_name
```

- Try to remember the syntax. Think about telling Git: "Git, merge [this branch name] into the one I am currently in!"

```
TODO: finish up from this
#### GitHub Specific - Pull Requests 'PR'
~~right hand side; pull requests~~
~~new pull request~~
~~2 drop down buttons, base: and compare:~~
~~explain base and compare~~
~~able to merge!~~
~~explain green/red~~
~~click create pr~~
~~refersh page, should see new prs!~~
~~click into that pull request~~
~~discuss etc~~
~~able to merge? merge~~
~~delete~~
~~go back homepage~~
~~cool!~~
~~your repository is now different~~
~~(git reset --hard if necessary)~~
~~switch to master branch~~
~~git pull~~
~~new stuff in master now that wasn't there before~~
~~git pull~~
~~in sample file, you guys change something~~
~~git status~~
~~git add [tab]~~
~~git commit -m "changed exxar"~~
~~git pull a change will resolve in merge conflict~~
```

## Step 3

- ???
- ???
-
## Step 4

- You are now Linus Torvalds, creator of Git, and Linux.
