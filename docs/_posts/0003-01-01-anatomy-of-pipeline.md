### Pipelines?

- Build Pipeline

  (Covered in CI bootcamp back in January, builds a tested + packaged artifact ready to be deployed when required)

- Release Pipeline

  (Deploys packaged code held in artifact to environments)

--

![Example](images/pipelines/simple-release-pipeline.png)

--

### Features of release pipelines

- Artifacts
- Stages
- Jobs
- Tasks
- Approvals/Conditions
- Tests
- Notifications

--

### Some Benefits

- Repeatable
- Improvabe
- Self documenting
- Tests, approvals, notifcations etc

--

![History Example](images/pipelines/release-history.png)

--

### History benefits

- May be possible to redeploy previous release if something has gone wrong
- Provides information regarding checks if something goes wrong (again with history of approvals and tests performed)
- Quick view of what's been deployed to where
- Can be used to analyse and improve deployment process

--

![Region example](images/pipelines/regions.png)

--

### Why they help when things get complicated

- Multiple stages with different regions
- Different stages can have different release builds at the same time
- Release pipeline could have multiple artifacts which need to be approved, released and tested before next artifact
