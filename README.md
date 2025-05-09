# User-Management-System (n-Tier Architecture)

This is a full-stack **User Management System** developed using n-tier architecture. It includes login authentication, a paginated user list, and functionality to add and edit users. The backend logic is encapsulated in stored procedures for clean separation of concerns.

## 📌 Project Features

- **Login Page**  
  - User can log in using either Email ID or Mobile Number.  
  - No access to other pages without successful login.

- **User List Page**
  - Displays 10 users per page.
  - Shows User ID, Name, Email ID, Mobile No, Department.
  - Pagination implemented.
  - Option to add a new user or edit existing users.

- **Add / Edit Page**
  - Form to add a new user or update existing one.
  - All fields include proper validation.
  - Department dropdown populated from `DeptMast` table (foreign key).
  
## 🧩 Technologies Used

- **Frontend**: ASP.NET Web Forms / MVC, HTML, CSS, JavaScript  
- **Backend**: C# with n-tier architecture (Presentation Layer, Business Layer, Data Access Layer)  
- **Database**: SQL Server with stored procedures  
- **Styling**: External CSS for consistent design and responsive layout  

