## percy_csharp_example

 1. Login to your Percy portal and create a new Project.
 2. Install NodeJS runtime
 3. Clone my updated [percy_csharp_selenium ](https://github.com/vvchens/percy-csharp-selenium.git)
 4. Add above to your project as dependency.
 5. Open Windows Terminal and run below command.
```bash
set PERCY_TOKEN=<YOUR_PERCY_PROJECT_TOKEN_FIND_IN_PORTAL>
npx @percy/cli exec:start
```
 5. You should see  **[percy] Percy has started!**
 6. Run the demo test as usual.
 7. Once the test is done, back to the terminal and press Ctrl-C.
 8. You should see **[percy] Finalized build**
 9. Back to your Percy portal to check the result.

## TODO:
Find a xUnit/nUnit Console Runner, then use below command to let percy automatically finish the build.
```bash
npx @percy/cli exec -- <ABSOLUTE_PATH_OF_THE_RUNNER.exe> <ABSOLUTE_PATH_OF_YOUR_TEST_PROJECT.dll>
```
