# Exercise 2

**Working with database migrations**

## Step 1 - Create a basic app

- Fork the repo
- ensure you have dotnet-ef tools installed golbally:
- dotnet tool install --global dotnet-ef

## Step 2 - See the application working

- Run the application
- See it working

## Step 3 - Make a change to the database

- Change one of the Models to add a new field
- Check the app doesn't work by going to /home/people
- Manually run a sql script against the DB to add the same column
- One way to do this is from within the Program.cs file
- i.e. context.Database.ExecuteSqlRaw("ALTER TABLE Person ADD Test INTEGER;");
- Check the app still works

## Step 4 - Switch the database

- Remove the ExecuteSqlRaw statement from the previous step
- Point the app to talk to a new database by changing the connection string in appsetting.json
- Should error saying column not found again

## Step 5 - Create a migration file

- Create a migration file for the DB using the following command:
- dotnet ef migrations add NameOfMigration
- Check the application works
- Note that migrations are being applied on startup via the line: context.Database.Migrate()

## Step 6 - Manually edit migration file

- You may have to create some changes manually in the migration file.
- 1). Try running a sql scripts via: migrationBuilder.Sql("");
- 2). Try setting a new default for the Name column via defaultValue: "A Default Name"
