### Version Control

By version control we mean things like Git. What is version control’s role in CD?

> Everything you need to build, deploy, test, and release your application should be kept in some form of versioned storage.

Note: Since this section is short, it is included verbatim in the slides.

--

> This includes requirement documents, test scripts, automated test cases, network configuration scripts, deployment scripts, database creation, upgrade, downgrade, and initialization scripts, application stack configuration scripts, libraries, toolchains, technical documentation, and so on.

--

> All of this stuff should be version-controlled, and the relevant version should be identifiable for any given build. That is, these change sets should have a single identifier, such as a build number or a version control change set number, that references every piece.

--

> It should be possible for a new team member to sit down at a new workstation, check out the project’s revision control repository, and run a single command to build and deploy the application to any accessible environment, including the local development workstation.

--

> It should also be possible to see which build of your various applications is deployed into each of your environments, and which versions in version control these builds came from.

From Continuous Delivery: Reliable Software Releases through Build, Test, and Deployment Automation, Chapter One

--

### Research tasks

* What version control workflow does your team use?
    * Are there situations or codebases where you should use a different flow?
    * Why do they use that workflow?
