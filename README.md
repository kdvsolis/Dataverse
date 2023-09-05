# Dataverse Project

This repository contains two main projects: the **Dataverse API** (backend) and the **Dataverse Frontend** (Blazor WebAssembly).

## Dataverse API (Backend)

The Dataverse API is a RESTful API built using ASP.NET Core that serves as the backend for managing products. It provides endpoints for creating, retrieving, updating, and deleting products. Below are the key features and instructions for running the backend project:

### Features

- Create, Read, Update, and Delete (CRUD) operations for products.
- Secure endpoints with authentication (e.g., JWT tokens).
- Store product data in a database (e.g., SQL Server or SQLite).

### Getting Started

1. Clone this repository to your local machine.

   ```bash
   git clone <repository-url>
   ```

2. Navigate to the `Dataverse.API` directory.

   ```bash
   cd Dataverse.API
   ```

3. Set up your database connection in the `appsettings.json` file.

4. Run the API.

   ```bash
   dotnet run
   ```

5. Access the API at `http://localhost:5067`.

### API Documentation

- API documentation (e.g., Swagger) can be added here.

## Dataverse Frontend (Blazor WebAssembly)

The Dataverse Frontend is a Blazor WebAssembly application that provides a user interface for managing products. It interacts with the Dataverse API to perform CRUD operations. Below are the key features and instructions for running the frontend project:

### Features

- List products and display their details.
- Add new products.
- Edit existing products.
- Delete products with confirmation.

### Getting Started

1. Clone this repository to your local machine (if not already done).

2. Navigate to the `Dataverse.Frontend` directory.

   ```bash
   cd Dataverse.Frontend
   ```

3. Run the frontend application.

   ```bash
   dotnet run
   ```

4. Access the frontend at `http://localhost:5224`.

### Usage

- Browse the product list, add, edit, and delete products as needed.

### Dependencies

- List any third-party libraries or frameworks used in the frontend.

### Contributing

- If you'd like to contribute to this project, please follow our [contributing guidelines](CONTRIBUTING.md).

### License

- This project is licensed under the XYZ License - see the [LICENSE](LICENSE) file for details.
