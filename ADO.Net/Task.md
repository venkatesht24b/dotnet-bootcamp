As a Retail stores company head, I want to get all stores information in a centralized database.
Current Challange: 
We have stores in Remote locations as well where Internet and electricity will be a big issue.
we have power backup setup but internet is a big challange for us.

In each store we are using a windows software by using which we are tracking all the details of customer, stock, purchases and warehouse information.
all these individual stores will use a centralized database to store or perform operations.

But due to above challanges, they were unable to connect to the central server.

so our team come with a plan to run their daily operations on a local database at their store level and by end of the day they will send all the data to the central server in different files.
by using this we have gained performance improvement in our system as we no need to connect to central server.
but we have to compromise data realtime delayed by 1 day. 

We finally agreed to this approach by having store level database in LAN. by end of the day their database will run the Job and generate different files with all the operations performed on that day.
Files Info:


