# Backstory of the Task:

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
below are Files Info

- Store Information  => Store_yyyyMMdd.csv (Comma delimeted) Ex: Store_20241121.csv
- Employees Information => Employee_yyyyMMdd.txt (Pipe delimeted)
- Customer Information => Sheet1(Customer) => Customer_yyyyMMdd.xlsx 
- Cusomer Purchase Order Items Information=> Sheet2(CustomerOrders) => Customer_yyyyMMdd.xlsx 
- Customer Billing Information=> Sheet3(CustomerBilling) => Customer_yyyyMMdd.xlsx 
- Stock Information => Stock_yyyyMMdd.txt (; delimeted)

The store will send all these files into a shared path location in server. which is (D:/DailyDataLoad/<StoreCode> Ex:D:/DailyDataLoad/STHYD001 )

Now The below task is the complete information about the task to push this data into Central database tables.
Todo that we need to implement a logic to see D:/DailyDataLoad folder every one hour recursively read all stores related files and validate them and store them into the DB.
while performing this job we wanted to logs and status information about how many files got processed.

# PBI Task: Centralized Data Load from Remote Stores to Central Database:

## Objective:
As a Retail Store company head, you want to synchronize daily data from remote stores into a centralized database. This task involves processing data files generated by local databases at individual stores, validating the data, and inserting it into central database tables. This job should log processing details, maintain a record of processed files, and handle errors systematically.

## Workflow Overview:
## File Processing Workflow
### Monitor the Shared Path:

The root folder is D:/DailyDataLoad.
Each store has a subfolder named by the store code (e.g., STHYD001, STHYD002).
Check for new files in each store's folder every hour.

## File Types:

## Files are provided in specific formats:
1. Store Information: Store_yyyyMMdd.csv (Comma-delimited)
2. Employee Information: Employee_yyyyMMdd.txt (Pipe-delimited)
3. Customer Information: Excel file with multiple sheets: Customer_yyyyMMdd.xlsx 
    - Sheet1: Customer (Customer details)
    - Sheet2: CustomerOrders (Purchase orders)
    - Sheet3: CustomerBilling (Billing details)
4. Stock Information: Stock_yyyyMMdd.txt (Semicolon-delimited)

## Validation:

Validate data in each file based on business rules.
Log errors for invalid data and skip processing such rows.

# Insert into Central Database:

Populate corresponding central database tables with validated data. Maintain relationships (e.g., linking customers to their orders and billing details).

## Move Files:
- After successful processing, move files to a Processed folder (D:/DailyDataLoad/{{StoreCode}}/Processed).
- Archive processed files in an Archive folder (D:/DailyDataLoad/{{StoreCode}}/Archive).

# Logging:
Log processing details, including:
Total files processed.
Number of records inserted, skipped, or errored for each file.
Error details for debugging.

# File Details
## 1. Store Information (Store.csv)
### Format: Comma-delimited.
#### Sample Data: Always ONLY 1 record will exists in this file.

    StoreID,StoreCode,StoreName,City,ManagerName,ContactNumber
    1,STHYD001,Hyderabad Main,Hyderabad,John Doe,9876543210

## 2. Employee Information (Employee.txt)
### Format: Pipe-delimited.
#### Sample Data:

    EmployeeCode|StoreCode|EmployeeName|Role|DateOfJoining|DateOfLeaving|ContactNumber|Gender|Salary
    Emp001|STHYD001|Alice|Cashier|2022-01-10|Null|99513126|Male|20000
    

# 3. Customer Information (Customer.xlsx)
### Sheet1: Customer

CustomerCode | Name      | Email            |ContactNumber| 
|------------|-----------|------------------|---------------|
| CUST001    | Charlie   | charlie@mail.    | 9123131414    |


### Sheet2: CustomerOrders
OrderCode  | CustomerCode | EmployeCode   | StoreCode | ProductCode | NoOfIteams |Amount    |OrderDate |
|----------|--------------|---------------|-----------|-------------|------------|----------|--------- |
| OR-001   |   CUST001    | Emp001        |STHYD001   |  PR100      |       5    |500       |22-02-2024|
| OR-001   |   CUST001    | Emp001        |STHYD001   |  PR101      |       7    |500       |22-02-2024|
| OR-001   |   CUST001    | Emp001        |STHYD001   |  PR103      |       3    |500       |22-02-2024|


### Sheet3: CustomerBilling
| BillingNumber | ModeOfPayment | OrderCode | BillingDate  | Amount  |
|-------------- |---------------|-----------|--------------|---------|
| OR-001-01     | Cash          | OR-001    | 2023-03-10   | 500.00  |
| OR-001-02     | PhonePay      | OR-001    | 2023-03-10   | 1000.00 |

# 4. Stock Information (Stock.txt)
## Format: Semicolon-delimited.
### Sample Data:
    ProductCode;StoreID;ProductName;QuantityAvailable;Date;PricePerUnit
    PR-001;STHYD001;Soap;50;10.00;27-11-2024;20
    PR-002;STHYD001;Shampoo;30;50.00;27-11-2024;21


# Database Schema
## Central Database Tables
### 1. Stores Table
| Column Name   | Data Type      | Constraints       |
|---------------|----------------|-------------------|
| StoreIdPk     | INT            | PrimaryKey,AutoIc |
| StoreCode     | VARCHAR(50)    | NOT NULL,Unique   |
| StoreName     | VARCHAR(100)   | NOT NULL          |
| Location      | VARCHAR(50)    | NOT NULL          |
| ManagerName   | VARCHAR(100)   |                   |
| ContactNumber | VARCHAR(15)    | NOT NULL          |
     
### 2. Employees Table
| Column Name      | Data Type       | Constraints            |
|------------------|----------------|-------------------------|
| EmployeeIdPk     | INT            | Primary Key,AutoIc      |
| EmpCode          | varchar(50)    | Not Null,Unique         |
| EmployeeName     | VARCHAR(100)   | NOT NULL                |
| Role             | VARCHAR(50)    |                         |
| DateOfJoining    | DATE           |                         |
| DatofLeaving     | DATE           |                         |
| ContactNumber    | VARCHAR(15)    | Uniqe,Not Null          |
| Gender           | VARCHAR(10)    |                         |
| Salary           | DECIMAL(10, 2) | Not Null                |
| StoreIdFk        | INT            | Foreign Key (Stores)    |

	
### 3. Customers Table
| Column Name      | Data Type      | Constraints          |
|------------------|----------------|----------------------|
| CustomerIdPk     | INT            | Primary Key,AutoIc   |
| CustomerCode     | VARCHAR(15)    | NOT NULL,Unique      |
| Name             | VARCHAR(100)   | NOT NULL             |
| Email            | VARCHAR(100)   | 		           |
| ContactNumber    | VARCHAR(15)    | NOT NULL,Unique      |


### 4. Orders Table
| Column Name   | Data Type      | Constraints             |
|---------------|----------------|-------------------------|
| OrderIdPk     | INT            | Primary Key,AutoIc      |
| StoreIdFk     | INT            | Foreign Key (Stores)    |
| CustomerIdFk  | INT            | Foreign Key (Customers) |
| EmployeeIdFk  | INT            | Foreign Key (Employee)  |
| OrderDate     | DATE           |  NOT NULL               |
| NoOfItems     | Int            |  NOT NULL               |
| Amount        | DECIMAL(10, 2) | NOT Null                |
| OrderCode     | VARCHAR(15)    | NOT NULL,Unique         |


### 5. OrderProducts Table
| Column Name   | Data Type      | Constraints                   |
|---------------|----------------|-------------------------------|
|OrderProductsId| INT            |  Primary Key,AutoIc     	 |
| OrderIdFk     | INT            | Foreign Key(Orders)     	 |
| ProductIdFk   | INT            |  Foreign Key (ProductMaster)  |
| Quantity      | DECIMAL(10, 2) |  NOT NULL                     |
| PricePerUnit  | DECIMAL(10, 2) |  NOT Null                     |
| Amount        | DECIMAL(10, 2) |  NOT Null                     |




### 6. Billing Table
| Column Name   | Data Type      | Constraints         |
|---------------|----------------|---------------------|
| BillIdPk      | INT            | Primary Key,AutoIc  |
| BillNumber    | VARCHAR(512)   | NOT NULL            |
| OrderIdFk     | INT            | Foreign Key (Orders)|
| PaymentMode   | VARCHAR(50)    |  NOT NULL           |
| BillingDate   | DATE           |  NOT NULL           |
| Amount        | DECIMAL(10, 2) |  NOT NULL           |



### 7. Stock Table
| Column Name        | Data Type      | Constraints          |
|--------------------|----------------|--------------------- |
| StockIdPk          | INT            |  Primary Key         |
| ProductIdFk        | INT            | Foreign Key (ProMast)|
| StoreIdFk          | INT            | Foreign Key (Stores) |
| Date               | Date           | NOT Null             |
| QuantityAvailable  | DECIMAL(10, 2) | NOT Null             |


### 8. ProductsMaster Table
| Column Name        | Data Type      | Constraints          |
|--------------------|----------------|--------------------- |
| ProductIdPk        | INT            | Primary Key          |
| ProductCode        | VARCHAR(500)   |                      |
| ProductName        | VARCHAR(100)   | NOT NULL             |
| PricePerUnit       | DECIMAL(10, 2) | NOT Null             |




# Business Rules
1. The Order of files processing would be Store-> Stock -> Customers->Orders-> Billing

## Validation:
1. StoreID in each file must exist in the Stores table.
2. Email addresses must be in a valid format.
3. Dates (e.g., OrderDate, BillingDate, DateOfBirth) must not be in the future.

## Relationships:
Ensure proper linking between Customers, Orders, and Billing tables.
Maintain foreign key constraints between tables.

# Error Handling:
Skip invalid rows and log the errors with file name, row number, and issue description.
Logging Requirements
## Log File Format:
Store logs in D:/Logs/DailyDataLoadLog.txt.
#### Log file entries should include:
[Timestamp] INFO: Successfully processed StoreID: STHYD001. Files: 5, Records: 125
[Timestamp] ERROR: Invalid email in StoreID: STHYD001, File: Customer.xlsx, Row: 10
#### Log Success and Failure Counts:
Total files processed, records inserted, and rows skipped for each store.

# Folder Structure
## Root Folder: D:/DailyDataLoad
## Subfolders: D:/DailyDataLoad/STHYD001/
1. Processed: Successfully processed files.
2. Archive: Historical files for backup.

# Expected Learning Outcomes
Working with various file formats (CSV, TXT, Excel).
Implementing folder monitoring with file operations.
Understanding relational database operations with ADO.NET.
Building a robust error handling and logging system.






