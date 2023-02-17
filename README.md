# PlatesMvc

I am creating an MVC Application using Visual Studio 2019.

Starting to get ready.. 0216 1657

The theme I had been assigned for the following assignment was titled "Plates".

To start off, 
I  set up GitHub account where I linked my current project so thsat I could update it as I move forward with it. 

1720

Adding up a controller, checking if the website runs, then moving forward with the process. 


1725

Moving forward with the Models page:

First of all, the Plates.cs page, 
Where I updated the data type and added various kinds of data types,
precisely 10 of the different data types. 

Saving it all, moving onto the next point. 

1740

Adding the NuGet Packages

I then installed the NuGet Packages..
Then, I created a Data Folder having PlatesMvcContext.cs file.

After which, I was had to register the database context with the following: 

public void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews();

    services.AddDbContext<PlatesMvcContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("PlatesMvcContext")));
}


1800

Scaffolding the database:

I then created a new scaffold item > MVC Controller Views, using Entity Framework.

Later on, starting up on Migration.

In the PMC, with the following command:

Add-Migration InitialCreate
Update-Database

Meanwhile, I got this error that said the page could not be processed. 

It was a silly mistake LOL, I forgot to hit Enter after the second line of command

Update-Database

which I then figured and sorted out.. 

After all this I tested the app if it was working. 

Which thankfully, it WAS !

Later on I figured that the PlatesMvc in my home page was not clickable, for which I had to go to the 
Layout.cshtml file and remove a portion of code, which made the text clickable. 

1946

Seeding the database:

First off, I created a new class named seedData inside the Models Folder. 

I added a list of codes that I needed. 

After which I started manually adding the values to its respective fields. 

When I was done with adding all the value into the respective fields I tried to see if my application
was still working without errors. 

Adding seed initializer..

For this process I replaced some contents from the Program.cs with the available tutorial code via
Microsoft. 

Tested the app one more time to get it running, and thankfully it is still working. 

2007

Now I add to add an About Us page, and had to make a certain changes to the other pages:
Privacy Policy,
Index/Home Page,
Database Page.

I made changes in the Layout page, added the other missing stuff to it. 

Now I had all my context ready and needed an image for the About Us page..

I created an image folder(img) inside the www.roots.com folder, inside of which I added an
image of my choice. 

For which I looked up a bootstrap template to match with all the responsive image detailing I wanted. 

2048

Now was time for some css and images to add. 
I created a new css file www.roots.com > css > style.css

For the css part I decided to give it a shot with bootstrap as it is already installed and ready to go inside of the Asp.net program, I 
thought why not?

Looking through all the cool templates in the site, I decided to go with the one that I liked. 
I picked one, as it already is installed inside the program I only had to change the class name where I wanted a change with css. 

2109

Taking a short break, its been a long day..


2140

I started out with changing a bit of colors in the css, the text color, background color..

I linked the css inside of all the four pages, 
Home page, Privacy Policy, Database, and About Us Page. 

The application is finally starting to come together, now that I am happy with it I am going to save all the files to 
gitHub and finish it altogether..


0217 1103

I finally have completed all the assignment parts and have read the rubric which I think went pretty well. 

Closing up with the readMe now, and submitting this..

Happy Reading :)
-Raisha <3







 
 









