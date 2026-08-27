# Inter University Recreation Facilities Management System (REMAKE)

In view of the high cost in building and maintaining sport and recreation facilities in a university 
campus environment, most of the universities in Malaysia provide a very limited choice of sport 
and recreation facilities for their students. 

Cozi Fitness Sdn Bhd, a locally established fitness center operator, has the intention of creating 
an application to pool all the sport and recreation facilities among the participating universities 
for sharing purposes. This approach will significantly increase the variety and number of facilities 
available for the students across participating universities to use. In return, Cozi Fitness will be 
fully responsible for maintaining the facilities to ensure that all the facilities are in good working 
order.  

Students who would like to use the facilities can book through the system directly or through the 
reception. However, the student must register as student user through the reception regardless of 
direct booking or booking through the reception. All payments must be made upon booking, and 
all the booking must be done in advance for at least ONE day. 
Universities that would like to participate in the program can contact Cozi Fitness Manager to 
register the facilities in the system to make them available for booking. 
Overview of System: 
Based on the Requirement Analysis conducted, the application needs to be developed must have 
the following characteristic: 
1. A Graphical Unser Interface (GUI) based Windows Desktop Application 
2. The application must be modelled and developed using Object-Oriented design and implementation. 
3. All the data will be stored in a DBMS system using MS SQL Server. 
4. There are 4 types of registered users which are Manager, Reception, Student, and Maintenance Staff. 

The system should have a login feature to allow the user to key in username/email and password only.
The system should identify role of the user and redirect to respective home 
page.  Following are the functionalities of each role: 

## a) Manager
- Manage user accounts (add, delete Reception & Maintenance Staff).
- Manage Sports and Recreation facilities information for each of the participated University 
(add, edit, delete – facility type, rate, etc).
- Assign maintenance schedule and assign maintenance staff to handle routine maintenance 
of the facilities.
- View and approve equipment repair or replacement request from the Maintenance Staff.

## b) Reception
- Manage Student account (add, delete student).
- Search for existing bookings by student name or facility code.
- Accept booking from the students (update facility availability, generate bill).
- Accept payment from the students and generate receipt.
- View review/rating from the students for each of the facilities.

## c) Student
- Search for available facility
- View facility details (type, location, rate).
- Perform booking of facility (add, edit, delete). Bill, payment and receipt will be handled 
by reception.
- Send review /rating for the facility.
- Update own profile.

## d) Maintainance Staff
- View facility maintenance schedule (own schedule).
- Update facility maintenance status.
- Manage cleaning supplies/equipment request (add, edit, delete).
- Raise equipment repair or replacement request.
- Update own profile. 
