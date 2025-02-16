# User Appointment Management System

This is a .NET 8-based appointment management system that allows users to create, manage, and view appointments with timezone support.

## Prerequisites

Before running the project, ensure you have the following installed:

- **.NET 8 SDK** ([Download Here](https://dotnet.microsoft.com/en-us/download/dotnet/8.0))
- **Microsoft Server SQL
- **Git** (optional, for version control)

## Setup Instructions

### 1. Clone the Repository

### 2. Configure the Database

- Update the database connection string in `appsettings.json` and `appsettings.Development.json`:

```json
"ConnectionStrings": {
    ...
    "dbname": "YOUR_DB_NAME",
    "username": "YOUR_DB_USERNAME",
    "password": "YOUR_DB_PASSWORD",
    ...
}
```

### 3. Run the Application

```sh
dotnet run
```

### Troubleshooting

- **Port already in use?** Run:
  ```sh
  dotnet run --urls=http://localhost:5001
  ```
- **Database issues?** Ensure the database server is running and the credentials are correct in `appsettings.json` and/or `appsettings.Development.json`.

### 4. Documentation
![Screenshot 2025-02-16 234313](https://github.com/user-attachments/assets/a4ae09e8-a7e9-4444-b79a-7298b826befa)
![Screenshot 2025-02-16 234319](https://github.com/user-attachments/assets/ce4b7581-4723-461e-a55c-4124293ae3f1)
![Screenshot 2025-02-16 234326](https://github.com/user-attachments/assets/635ea6bc-62d0-4d0a-8fd6-4e52941002f5)
![Screenshot 2025-02-16 234339](https://github.com/user-attachments/assets/ff57c857-3f86-4c77-a773-c43edc63c6a8)
![Screenshot 2025-02-16 234355](https://github.com/user-attachments/assets/1fd71981-2bad-4fcd-bce5-fa2d69a6cc5c)
![Screenshot 2025-02-16 234448](https://github.com/user-attachments/assets/f5f4a590-3a8b-42ff-a33a-da3791307a59)
