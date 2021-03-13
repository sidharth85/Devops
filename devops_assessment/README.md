# DevOps Assessment

This assessment will require you to set up a basic CI/CD pipeline, this can be done on the following platforms:

* Github + Github actions
* Gitlab + Gitlab pipelines
* Bitbucket + Bitbucket pipelines
* Any git repository + Bamboo

For publishing the docker images, you can either use Docker Hub or a registry provided by your source control server.

## Task 1

Our developers have created a new application and need your help with publishing it. It's a simple dotnet application consisting of two services, Service1 and Service2. These services should be published to a docker registry for further distribution. The requirements for these images are as follows:

* unix OS
* dotnet core runtime 3.1
* Follow general best practices for publishing docker images

We expect this pipeline to build and publish the images on each commit. A clear distinction should be made in the versioning of a feature branch and the main git branch, which can be considered as release branch for this exercise.

## Task 2

Our developers also wrote some unit and integration tests, which should also be added to our pipeline.

*Unit tests*:

* Service1.UnitTests
* Service2.UnitTests

These can be executed using the `dotnet test` command. We will also expect the results to be published as a build artifact.

*Integration tests*:

* Service1.IntegrationTests

These are a little more complex, as they will require the application to be up and running before being executed. So we'll need to set up our services first, and then run these tests against their API's. As with the unit-tests, we would also like the results to be published as a build artifact.

*Gates*:

These tests should be considered as gates, and publishing the image should be prevented if any test fails.
