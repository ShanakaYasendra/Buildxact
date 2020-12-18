# Buildxact

## Setup
Nuget Package use to add the dependencies.

## Before you run the test please update the password for reset password and also update the new user data.
## Please follow the comments in the code

## Test Cases
### Test 1 – Login, and logout
  Steps:
  1.	Login to one of the tenants provided to you
  2.	Confirm user lands on the Dashboard page
  3.	Logout of the tenant and confirm user lands on the login page.





 
### Test 2 – Reset Primary User password via logged-in Session
  Steps:
  1.	Login to a second tenant provided to you
  2.	Navigate to My Profile
  3.	Click Reset Password
  4.	Click OK in the confirmation pop-up
  5.	Logout of the Buildxact app
  6.	Navigate to the user’s mailbox
  7.	Open the Password Reset request email
  8.	Click the link to reset the user’s password
  9.	Enter the new password in the New Password field
  10.	Enter the new password on the Confirm New Password field
  11.	Login and confirm user lands on the Dashboard page
  12.	Logout
  13.	Attempt to login with the old password, confirm this fails
 
### Test 3 – Create a new user
  Steps: 
  1.	Login to one or the other tenant
  2.	Navigate to My Business > Users
  3.	Click the Add User button
  4.	Complete user information on New User form and submit
  5.	Logout
  6.	Navigate to the new user’s mailbox
  7.	Open the Welcome email
  8.	Click the Activate button to activate the new user
  9.	Enter the new user’s password in the New Password field
  10.	Enter the new password on the Confirm New Password field
  11.	Click the login button
  12.	Confirm user lands on the Dashboard page

