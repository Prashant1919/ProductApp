# 📦 Inventory Management System

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black)
![SQL Server](https://img.shields.io/badge/SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)

> A full-stack web application designed to streamline product inventory tracking. Built with a decoupled **ASP.NET Core RESTful API** backend and a dynamic **JavaScript** frontend.

## 🚀 Project Overview
This system provides a seamless interface for businesses to manage their stock. It replaces manual tracking with a digital solution that allows for real-time CRUD (Create, Read, Update, Delete) operations on product data.

The project demonstrates a professional **Layered Architecture** (Separation of Concerns), ensuring that the Data Access, Business Logic, and UI layers are distinct and maintainable.

## 🔑 Key Features
* **✨ Full CRUD Operations:** Users can effortlessly Add, View, Update, and Delete product records.
* **⚡ Real-Time Data Rendering:** The frontend uses vanilla JavaScript to fetch data asynchronously from the API without page reloads.
* **🏗️ Layered Architecture:** Implemented a clean separation between the Controller, Service, and Repository layers.
* **🔍 Optimized Performance:** Fine-tuned SQL queries and API endpoints to ensure fast response times even with growing datasets.

## 🛠️ Tech Stack
* **Backend:** ASP.NET Core Web API (C#)
* **Frontend:** HTML5, CSS3, Vanilla JavaScript (ES6+)
* **Database:** Microsoft SQL Server
* **Architecture:** RESTful API, Repository Pattern
* **Tools:** Visual Studio, Postman, SSMS

## ⚙️ Technical Highlights
### 1. Layered Architecture
To ensure scalability, I avoided writing business logic directly in the Controllers.
* **Controller:** Handles HTTP requests and responses.
* **Service Layer:** Contains business logic and validations.
* **Repository Layer:** Handles direct database interactions.

### 2. RESTful API Design
The backend exposes standard HTTP methods for seamless frontend integration:
* `GET /api/products` - Fetch all inventory
* `POST /api/products` - Add new stock
* `PUT /api/products/{id}` - Update details
* `DELETE /api/products/{id}` - Remove items

## 💻 Installation & Setup
1.  **Clone the repository**
    ```bash
    git clone [https://github.com/Prashant1919/ProductApp.git](https://github.com/Prashant1919/ProductApp.git)
    ```
2.  **Database Configuration**
    * Open `appsettings.json`.
    * Update the `ConnectionStrings` with your local SQL Server instance.
    * Run the database migration command (or SQL script) to create the `Products` table.
3.  **Run the Backend**
    * Open the solution in **Visual Studio**.
    * Press **F5** to start the API server.
4.  **Launch Frontend**
    * Open `index.html` in any browser (or use Live Server).

