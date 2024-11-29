# Project Overview

## Objective
Developing an ASP.NET Core Web API designed to connect clients with skilled craftsmen who can perform a variety of tasks, whether at home, in the yard, barn, or workplace. The platform aims to seamlessly facilitate the matching process, making it easier for customers to find reliable professionals for domestic or business-related projects.

## Description
This project is designed to be a full-featured ASP.NET Core web application where users can discover and book artisans, communicate directly through a real-time chat, and receive detailed service orders that include pricing and the platform's calculated commission. After the work is completed, the client confirms the order. 

The platform also includes a **tool store** where both customers and artisans can purchase tools of various sizes. A card popup provides details such as size, quantity, and price, with all sales tracked and archived in a dedicated sales table. The application uses **ASP.NET Core Identity** for authentication, tracking users and authorizing access based on roles like admin, super-admin, customer, or artisan, ensuring secure and role-based access to different features, including managing tool inventory and pricing.

## Technologies
- ASP.NET Core Web API
- Entity Framework Core
- T-SQL
- User Authentication
- Soft-delete

## Design Patterns
- Repository Design Pattern with Unit of Work
- Inversion of Control using Dependency Injection

---

# Development Plan

## Week 1: Initial Database Design and Migration
**Tasks:**
- **Project Setup (N-tier Architecture):** Set up the project environment by installing and configuring ASP.NET Core Web API with a layered architecture, including a Data Access Layer (DAL) for repository pattern and a Business Logic Layer (BLL) for manager services.
- **Database Design:** Created the initial database schema, covering entities such as users, workers, orders, reviews, chats, tools, sizes, cards, and sales.
- **Entity Framework Code-First Approach:** Defined entity attributes and relationships between models, set up DbContext, and seeded initial data for testing purposes during development.
- **Database Migration:** Successfully migrated the database to SQL Server using the ORM capabilities of Entity Framework.

**Deliverables:**
- ASP.NET Core project set up using N-tier architecture.
- Initial database schema created via Entity Framework Core.
- Migration of database models to SQL Server using the code-first approach.

---

## Week 2: Model Implementation and Role-Based Access Control
**Tasks:**
- **Soft-Delete Implementation:** Introduced soft-delete functionality to enable archiving of records without permanent deletion, preserving data integrity.
- **Location Services:** Integrated Leaflet.js to enable users to determine and share their location within the application.
- **Authentication and Authorization:** Implemented role-based access control (RBAC) using ASP.NET Core Identity to authenticate and authorize users, workers, admins, and super admins.
- **Endpoint Development:** Created foundational endpoints for managing tools, users, clients, workers, and crafts.

**Deliverables:**
- Implemented soft-delete functionality for archiving.
- Developed models for login and registration.
- Initial endpoints created for various actors (users, workers, tools, etc.).

---

## Week 3: Completing Models and Building Real-Time Chat
**Tasks:**
- **Chat Implementation:** Developed real-time chat functionality using SignalR to facilitate direct communication between users and artisans.
- **Role-Based Access Control (RBAC):** Finalized the assignment of role-specific permissions, ensuring that each role has access to its respective endpoints.
- **Endpoint Completion:** Completed the development of all remaining actor-based endpoints.
- **Initial Testing:** Performed initial testing to ensure endpoint compatibility and proper functionality.

**Deliverables:**
- Fully functional chat interface built using SignalR.
- Role-based authorization and endpoint access control completed.
- Completion of all endpoint implementations.
- Initial testing of key features.

---

## Week 4: Building Dashboard and Final Testing
**Tasks:**
- **Dashboard Development:** Constructed a comprehensive management dashboard for the tool store. This dashboard is accessible exclusively to admins for modifying properties of existing product attributes, while super admins possess additional privileges to add new products and delete existing ones.
- **Performance Testing:** Conducted a thorough final assessment of the application’s performance using Postman. This included executing a series of tests to validate the correctness of responses, identify potential bottlenecks, and ensure that the application meets performance benchmarks.

**Deliverables:**
- Fully functional dashboard tailored for both admins and super admins.
- Completion of the testing phase, including performance assessments and endpoint validations using Postman.
