# PS Backend

## Database Setup

### 1. Update the Connection String

Edit the `API/appsettings.Development.json` file with your local SQL Server settings:

```json
"ConnectionStrings": {
    "SqlServer": "Server=localhost;Database=BoschBooking;Trusted_Connection=True;TrustServerCertificate=True"
}
```
If you're using SQL authentication:
```json
"ConnectionStrings": {
    "SqlServer": "Server=localhost;Database=BoschBooking;User Id=YOUR_USER;Password=YOUR_PASSWORD;TrustServerCertificate=True"
}
```

### 2. Apply Migrations

Run the following commands from the root of the backend solution:

```powershell
cd .\PS_back\
```
```powershell
dotnet ef database update --p Infraestructure/Infraestructure.csproj --s API/API.csproj
```
This will apply the existing migrations and create the database if it doesn't exist.

## Running the Application

To run the API locally:

```powershell
cd .\API\
```
```powershell
dotnet run
```

The API will start at:
```
http://localhost:5124
```