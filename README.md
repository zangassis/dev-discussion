## DevDiscussion 👩‍💻🏓👨‍💻

**This project contains a sample ASP.NET Core app. This app is an example of the article I produced for the Telerik Blog (telerik.com/blogs).
**
DevDiscussion is an ASP.NET Core project that combines Database First and Code First approaches to streamline your development process.

**🔧 Setup:**

1. **Clone the Repository:**
   ```
   git clone https://github.com/zangassis/dev-discussion.git
   ```

2. **Database First Approach:**
   - Navigate to `UserManagementService` directory.
   - Modify the connection string in `appsettings.json` to point to your database.
   - Ensure you have the necessary packages installed via NuGet.

3. **Code First Approach:**
   - Navigate to `ForumManagementService` directory.
   - Define your entities in the `Models` folder.
   - Modify the connection string in `appsettings.json` to match your database setup.
   - Run Entity Framework Core migrations:
     ```
     dotnet ef migrations add InitialCreate
     dotnet ef database update
     ```

4. **Run the Application:**
   - Navigate to the root directory.
   - Execute:
     ```
     dotnet run
     ```

**🛠️ Features:**

- **Database Integration:** Seamlessly integrate with existing databases or create new ones using Entity Framework Core.
- **ASP.NET Core MVC:** Utilize the power of ASP.NET Core MVC for building robust web applications.
- **Flexible Configuration:** Easily configure your database connection strings and other settings in the `appsettings.json` file.
- **Efficient Development:** Combine Database First and Code First approaches for a versatile development experience.

**📋 Usage:**

- Explore the `Controllers` to understand the application flow.
- Customize and extend the functionality to suit your project requirements.

**📦 Dependencies:**

- ASP.NET Core
- Entity Framework Core
- Microsoft.EntityFrameworkCore.SqlServer

**📝 License:**

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
