# IS413_BookStore

DESCRIPTION:
Model first database, pagination, etc.



ASSSIGNMENT 5:
Jeff Bezos was 30 years old when he quit his job and founded Amazon in 1994, selling books
online out of his garage. His parents provided the seed money of $250,000. Amazon launched
their website in 1995, where revenue totaled $511,000 in their first five months. After receiving
an additional $8 million in funding in 1996, total revenue that year jumped up to $15.7 million.
The company went public in 1997, just shy of three years after the company was founded, and
Bezos made an approximate $54 million in that IPO. By 1999, five years after starting Amazon,
Bezos made his first appearance on the Billionaires list. He has said: “A brand for a company is
like a reputation for a person. You earn reputation by trying to do hard things well.”
It took a full year to develop, test, and debug the Amazon website. We are going to build
something similar in just a few weeks using ASP.NET Core MVC over the course of the next
few assignments. This assignment focuses on creating the database portion of the web app.
Create a web app for an online bookstore. For each book, we want to store the following
information:
• Title
• Author
• Publisher
• ISBN
• Classification/Category
• Price
All fields are required. Use the “Model First” approach described in the videos to set up and
create the database that we will use for the app. The ISBN needs to be entered in a valid format.
Include a “BookId” field that can be used as a primary key. Use good normalization principles
(i.e. no non-atomic fields, no repeating groups).
Seed the database using some of Prof. Hilton’s favorite books he’s read over the last few years
(found in the table on the next page).
Once the database has been created, list out all the books from the database on the Index view.
Be sure to style your page using Bootstrap (#notcovered in the videos, but there is a section at
the end of Chapter 7 in the Freeman textbook that goes over some styling techniques.)
Submit a link to the GitHub repository containing your assignment via Learning Suite.
(NOTE: If you cannot submit via GitHub, you can submit a link to a .zip file, but you will
lose 5 points.)



ASSIGNMENT 6
Continuing the Bookstore project we started in Assignment #5, we are going to add Pagination to
our web app (using Tag Helpers) so that the number of pages and navigation is automatically
generated based on the number of items in the list.
We will display 5 items per page.
Improve the URLs so that the user can type /P2 to access the second page and /P3 to access the
third page and so on.
Use Bootstrap to display the information in an attractive way. Use at least three new Bootstrap
commands that you have never used before that are different from those used in Chapter 7.
(#notcoveredinthevideos #notmeanttobedifficult – List the commands you used in the comments
when you submit the program.) The page navigation should function so that the current page is
highlighted in the list of page numbers, and that hovering over a page changes the appearance of
the link as well.
We want to start tracking the number of pages in the book as well. Update the model to store the
number of pages, and then update the database, and add the number of pages to the view.
After you have incorporated the Pagination, add three of your own favorite books to the
SeedData, and rebuild the database to test that the Pagination works as it should.
Submit a link to the GitHub repository containing your assignment via Learning Suite.
(NOTE: If you cannot submit via GitHub, you can submit a link to a .zip file, but you will
lose 5 points.)
Here are the page numbers for the books from the previous assignment:
• Les Miserables: 1488
• Team of Rivals: 944
• The Snowball: 832
• American Ulysses: 864
• Unbroken: 528
• The Great Train Robbery: 288
• Deep Work: 304
• It’s Your Ship: 240
• The Virgin Way: 400
• Sycamore Row: 642
