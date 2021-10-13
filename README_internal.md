README for ASP.NET USPlayingCard Application

Program name: USPlayingCard
Program purpose: Create an application for playing cards using ASP.NET Core
Program Author: Yashvi Raja
Date Modified: 2021-0545

Oct 4 – 5:55pm
Start working on assignment, first of all create repository on GitHub with name Playing-Card-Company, then open visual studio and start working on part 1 - create new project named USPlayingCard and run the app.

6:10 pm - Start part 2 – add new controller.
Add new HelloWorldController then try to run welcome message. After that add parameters in welcome method to display name and num times. Now change the parameter to id with default value 1. Run the app and it shows correctly.
Take 2 mins hold. Now move on next step. 

End – 6:27. now it’s time for dinner.

6:55pm 
Start part 3 – Add a view and change the layout of pages. Make change in title, footer and menu link in the layout file.

7:15pm – Start part 4 – add a model class.
Add scaffold pages to produce Create, Read, Update, and Delete (CRUD) pages for the Card model. 

7:19 – when I try to add migration and update database. I found error that more than one DbContext was found specify which one to use. 
So, I type in package manager console that Add-Migration Changetablename -Context USPlayingCardContext.
To update databse – I write Update-Databse -Context USPlayingCardContext. 

Try to run app and select The United States Playing Cards Company link. 
Examine the generated database context class and connection string. Examine the contents of details.cshtml file.

Now need to take a break and will continue tomorrow.  

Oct 3: 9:35am - Start part 5 – work with database.
Examine the records added in database from view menu. 
Create a new class named SeedData in the Models folder.
This class add records in Cards table. Now run the application and app shows the seeded data. 

Oct 5 - 9:55am – Start part 6 - controller methods and views.
Include Http post edit method and include properties in bind attributes. Read through the tutorial instruction follow step by steps. When click on edit link, it displays data in the textbox by http post method.

10:33am – start part 7 – add search capability to the Index method that search cards by brand and name. when I submit a search, the URL contains the search query string. 

11:45am – start part 8 – add a new filed rating
Because I add a new field to Card class, I need to update the property binding list so this new property will be included.
Then update the view templates in order to display, create, and edit the new Rating property in the browser view. Update the SeedData class so that it provides a value for the new column. 

12.02pm – Upload images in wwwroot folder, make new folder image and put all images in it.

12:17pm – start part 9 - add validation rules to the card model.
Update the card class by adding built in required, string length, regular expression and range validation attributes.

Oct 6 - 1:05pm – change data type of rating to string in card.cs page and add migration.  

Working on display image on detail page of the site. Add new filed imageUrl that contain string for image path. Add new imageUrl in seed data. Make some changes in CSS to change in layout of the website.
Add details of the company on home page that is index. cshtml page.

Add migration for imageUrl and update database. I have to write DbContext name every time when I add migration and update database.

1:22pm - Add new page about in Views in Home folder. Add about method in HomeController.cs page that will return view(). 

Update card.cs page to display imageUrl filed as Image. And change path of image in seed data. Now add <img src=””> tag in details page to display image. Add height and width of the image in CSS. 

Publish site on azure, first create account on azure (for student starter).
Now when I click on  name of the company, it shows error for deployment environment should not be enabled for deployed applications.

Oct 9 - 7:30pm – add policy details of the company in policy page of the site.

Oct 13 - 9:35 
add new link for playing card in header.
evry time when i first try to run application from any computer, i have to add migration and update database. after that when i update database, sometimes i can not see ImageUrl in database.

