# C Sharp Mettle Assessment

## Duration 2.5 Hours

## Problem Statement

You are working as a software developer in Techno Solutions. You have been assigned the task to create an `Expense Tracker App` in C# Console Application to track daily expenses and income. The requirements of the application are listed below

- Application should be able to capture the details of the expenses as well as the income.
- Expense or Income record should include the `title`, `description`, `amount` & `date`.
- Application should be able to show the `Income Transactions` & `Expense Transactions`.
- If the record is entered with negative value, it should be considered as `Expense` otherwise it should be an `Income`.
- Application should also calculate the available balance based on the income and expenses.
- All data should be stored in List collection.
- Upon starting the application it should display the menu and take the input from the user and perform the task as per the entered value. The menu should have below mentioned options-
1. Add Expense
2. Add Income
3. View Expenses
4. View Income
5. Check Available Balance
- On selecting the option 1 or 2 i.e Add Expense or Add Income it should ask for `title`, `description`, `amount` & `date`. Data should be stored in List collection.
- On selecting the option 3 or option 4 i.e View Expense or View Income it should display the records accordingly.
- In addition the `Available Balance` should be stored in an external text file and when user select option 5 for checking the `Available Balance` it should read the data from file and display the balance.
- Handle the exceptions properly to avoid any abnormal crashes in the application.
- In case if the entered option is not valid it should give a message `Wrong Choice Entered`.
- The menu should be displayed again when each transaction is complete which means it should run in an infinite loop.
- ***IMPORTANT - There should be a modularity in your code. Keep everything clean and separate. Follow Object Oriented paradigms.***
