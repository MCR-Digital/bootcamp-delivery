# Exercise 1
**Deploy an application to Heroku and configure environment variables**

## Step 1 - create basic web app
- Create new basic web app from template (suggested: .net core web application mvc)
- Push to github

## Step 2 - Create app in heroku
- Create/login to heroku
- Create a new app
- Set the build pack in Dashboard - app -  settings to: https://github.com/jincod/dotnetcore-buildpack.git

More details: 
https://elements.heroku.com/buildpacks/jincod/dotnetcore-buildpack#buildpack-instructions

## Step 3 - Push code from Github
- Connect to github
- Deploy master
- Wait for build to finish
- View in browser

## Step 4 - Automatic deployments
- In heroku: configure automatic deployments
- Make a change locally:
  - Add a environment variable to app settings
  - Display this value on the home page
- Push this change to github
- View automatic build
- View in browser

## Step 5 - Set config variables
- Set Heroku config variable in settings tab to overwrite appsettings.json value
- View in browser

## Step 6 - Create a pipleine
- Create pipeline
- Create a new app called prod following the same steps for the first app
- do not set automatic deployment
- Set a different env variable
- Make a simple change to the app
- Watch it push to staging automatically
- Promote this change to production

## Step 7 - (Optional) ????
- Implememnt a CI build pipeline with travis
- Implement a simple test that fails
- Make sure app is not deployed with failing tests
- Guide: https://docs.travis-ci.com/user/deployment/heroku/
