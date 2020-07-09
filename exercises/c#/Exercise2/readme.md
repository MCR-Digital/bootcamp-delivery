# Exercise 2
**Working with database migrations**

## Step 1 - Create a basic app
- Fork the repo

## Step 2 - See the application working
- Run the application
- See it working

## Step 3 - Make a change to the database
- Change one of the Models to add a new column
- Check the app doesn't work
- Manually run a sql script against the DB to add the same column
- Check the app still works

## Step 4 - Switch the database
- Point the app to talk to a new database
- Should error saying column not found

## Step 5 - Create a migration file
- Create a migration file for the DB using the following command
- ...
- Apply the migration
- Check the applciation works

## Step 6 - Apply DB migrations on startup
- Switch the database again
- Make the migration run on startup so it doesn't have to be run manually
- Run the application, check the console to see sql being applied