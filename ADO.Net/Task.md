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
below are Files Info:
=============================
Store Information  => Store.csv (Comma delimeted)
Employees Information => Employee.txt (Pipe delimeted)
Customer Information => Sheet1(Customer) => Customer.xlsx 
Cusomer Purchase Order Items Information=> Sheet2(CustomerOrders) => Customer.xlsx 
Customer Billing Information=> Sheet3(CustomerBilling) => Customer.xlsx 
Stock Information => Stock.txt (; delimeted)

The store will send all these files into a shared path location in server. which is (D:/DailyDataLoad)

for every store there is a dedicated folder with store code for example( STHYD001, STHYD002, STTPT003, ...ETC) in code we are also representing the city name.

Now The task is to push this data into Central database tables.
Todo that we need to implement a logic to see D:/DailyDataLoad folder every one hour recursively read all stores related files and validate them and store them into the DB.
while performing this job we wanted to logs and status information about how many files got processed.









