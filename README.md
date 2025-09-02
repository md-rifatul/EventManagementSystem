# QuickEvent Management System

**Project Type:** ASP.NET Core MVC
**Project Name:** QuickEventManagementSystem
**Company Name (Header):** Quick-Event Solution Ltd.

---

## ✅ Project Overview

This web application manages events and users. It demonstrates **MVC architecture**, **C# enums**, **Razor views**, and **in-memory data management**.

**Features:**

1. **Header Navigation** – Shows company name and links:

   * Home
   * All Events
   * Upcoming Events
   * Users

2. **Home Page** – Displays welcome message:

   ```
   Welcome to Quick-Event Solution Ltd.
   ```

3. **All Events Page** – Displays all events (past & upcoming) in a table.

4. **Upcoming Events Page** – Displays only future events based on current date.

5. **Users Page** – Displays all users with First Name, Last Name, Contact Number, Email, and User Type (Admin, Standard, External, Guest).

6. **Footer** – Shows the designer’s name:

   ```
   This Application is Designed By Md. Rifatul Islam
   ```

7. **Default Page** – Opens on **Upcoming Events**.

---

## 🗂 Project Structure

```
QuickEventManagementSystem/
│
├── Controllers/
│   ├── EventController.cs
│   ├── HomeController.cs
│   └── UserController.cs
│
├── Models/
│   ├── Event.cs
│   ├── User.cs
│   ├── UserType.cs
│   └── ErrorViewModel.cs
│
├── Data/
│   └── SeedData.cs  // Hardcoded sample users & events
│
├── Views/
│   ├── Event/
│   │   ├── AllEvents.cshtml
│   │   └── UpcomingEvents.cshtml
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   ├── User/
│   │   └── AllUsers.cshtml
│   └── Shared/
│       ├── _Layout.cshtml
│       ├── _ViewStart.cshtml
│       └── _ViewImports.cshtml
│
├── wwwroot/  // CSS, JS, images
├── appsettings.json
└── Program.cs
```

---

## 🔹 Model Specifications

### Event

| Property     | Type     | Description                    |
| ------------ | -------- | ------------------------------ |
| EventId      | int      | Unique identifier              |
| EventName    | string   | Name of the event              |
| Description  | string   | Description of the event       |
| Date         | DateTime | Event date                     |
| Address      | string   | Event location                 |
| AssignedUser | User     | User responsible for the event |

### User

| Property      | Type   | Description                                     |
| ------------- | ------ | ----------------------------------------------- |
| UserID        | int    | Unique identifier                               |
| FirstName     | string | First name of the user                          |
| LastName      | string | Last name of the user                           |
| ContactNumber | string | User phone number                               |
| Email         | string | User email address                              |
| UserType      | enum   | Type of user (Admin, Standard, External, Guest) |

### UserType Enum

```csharp
public enum UserType
{
    Admin = 1,
    Standard = 2,
    External = 3,
    Guest = 4
}
```

---

## 🔹 How to Run the Project

1. **Clone the repository**

```bash
git clone <your-repo-url>
```

2. **Open in Visual Studio**

   * Open `QuickEventManagementSystem.sln`.

3. **Build the project**

   * Make sure all dependencies are installed (ASP.NET Core 7.0 or later recommended).

4. **Run the project**

   * Press `F5` in Visual Studio or via terminal:

   ```bash
   dotnet run
   ```

5. **Default Page**

   * Opens on **Upcoming Events** page.

---

## 🔹 Notes

* The application currently uses **hardcoded data** stored in `SeedData.cs`.
* Events include **past and future dates** for demonstration.
* User types are displayed using **enums** for readability.
* Tables are styled using **Bootstrap**.
* You can extend this project later to use **EF Core + database** for persistent storage.

---

## 📝 Designer

**Md. Rifatul Islam**
