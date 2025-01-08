# 🌳 Logi-Park Project

## Overview
Logi-Park is a comprehensive project designed to facilitate efficient management and operations within a logistics park. It incorporates server and client components, testing suites, and a streamlined login system.

### Purpose
The City of Waterloo approached us to develop Logi-Park, aiming to modernize the existing parks directory and address user concerns. Logi-Park enhances user experience by providing interactive park reviews, up-to-date mapping, and a user-friendly interface, fostering engagement with local green spaces.

### Features
- **Server Management**: Includes robust server-side functionalities to handle requests efficiently.
- **Client Interface**: A user-friendly interface for seamless interaction.
- **Automated Testing**: Comprehensive test suites for both server and client components.
- **Login System**: Secure and intuitive authentication mechanisms.
- **Park Information**: Browse and review parks with star ratings, images, and user comments.

---

## 🎯 Target Users and Stakeholders

### Target Users
- Couples, families with children, teenagers, university students, and the elderly population.
- Residents of the Waterloo area looking for outdoor activities and green spaces.

### Stakeholders
- Google, Amazon, United Nations, City of Waterloo Councillors, Waterloo Region Real Estate Board, GRCA, local environmental groups, and the City of Waterloo Parks, Forestry, and Cemetery Services.

---

## 🌱 Environmental and Social Impact

### Motivation
Green spaces improve air quality, reduce crime, and promote mental and physical health. The United Nations Sustainable Development Goals (SDGs), including Good Health and Well-being, Sustainable Cities, and Climate Action, align with the objectives of Logi-Park.

### Benefits
- Reduces air pollution by promoting outdoor activities.
- Encourages healthier lifestyles by connecting people to nature.
- Supports local businesses by attracting more visitors to parks.

---

## 📁 Project Structure
The project is organized into the following key directories and files:

- `Logi-Park-Login/`: Contains the login system implementation.
- `Server/`: Includes the server-side logic and functionalities.
- `Client_Test_Suite/`: Automated test cases for the client component.
- `Server_Test_Suite/`: Automated test cases for the server component.
- `Server_Testing/`: Additional testing resources for the server.

---

## 📋 Requirements
To run or contribute to this project, ensure you have the following:

- **Development Environment**: Visual Studio 2022 or later.
- **Languages/Frameworks**: C#, .NET Framework 6.0 or later.
- **Testing Tools**: NUnit or any compatible testing framework.
- **Database**: SQL Server or a compatible alternative (due to time constraints, it is current a file system)

---

## ⚙️ Setup and Installation
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-repo/Logi-Park.git
   ```

2. **Open the Solution File**:
   - Navigate to the project directory.
   - Open `Logi-Park.sln` in Visual Studio.

3. **Install Dependencies**:
   - Restore NuGet packages using:
     ```bash
     dotnet restore
     ```

4. **Build the Solution**:
   - Build the project in Visual Studio to resolve dependencies and compile the code.

5. **Run the Application**:
   - Configure the startup project (e.g., server or client) and run it from Visual Studio.

---

## 🚀 Usage
- **Launching the Application**:
  - Start the server module first to handle client requests.
  - Use the client application to interact with the system.

---

## 🔬 Types of Tests
Testing is an integral part of ensuring the quality and reliability of the Logi-Park application. Below are the types of tests implemented:

### Unit Testing
- Focuses on individual components of the application.
- Ensures that each function, method, or module works as intended in isolation.
- Tools used: NUnit or compatible frameworks.

### Integration Testing
- Validates the interaction between different modules or components.
- Ensures that data flows correctly across the server, client, and database.
- Simulates real-world scenarios for functionality verification.

### System Testing
- Verifies that the entire application functions as a cohesive unit.
- Includes end-to-end testing of workflows, such as user login and park reviews.
- Ensures compliance with functional and system requirements.

### Usability Testing
- Evaluates the user interface and experience.
- Ensures the application is user-friendly and intuitive for all target demographics.
- Feedback is collected through user surveys and interaction analysis.

### Performance Testing
- Assesses the application's performance under different loads.
- Identifies bottlenecks and ensures the system can handle expected traffic.
- Includes stress and load testing for server components.

### Security Testing
- Focuses on identifying vulnerabilities in the system.
- Validates secure user authentication and data protection mechanisms.
- Simulates potential attacks to ensure system integrity.

### Regression Testing
- Ensures that new changes or updates do not break existing functionality.
- Automated tests are re-executed to validate stability after modifications.

---

## 🖼️ Screenshots
To better illustrate the features and functionalities of Logi-Park, below are some screenshots of the application:

### Login Screen
A secure and intuitive interface for users to log in.

![image](https://github.com/user-attachments/assets/2dc0750e-0971-469d-ba4b-13721e73f9da)


### Park List View
Displays a list of parks with names, locations, and ratings.

![image](https://github.com/user-attachments/assets/d3291c7f-c8ce-46f3-90dd-b42388ae0b04)


### Park Details
Detailed view of a selected park with reviews, images, and more.

![image](https://github.com/user-attachments/assets/350dfa0a-2066-424c-966f-5df2fe55916f)


### Admin Dashboard
Interface for administrators to manage parks, reviews, and users.

![image](https://github.com/user-attachments/assets/a7e4b0bb-976e-4b44-91ce-0274e6b5c02b)

### Admin Delete Park and Park Reviews
Enables administrators to remove parks and associated reviews efficiently.

![image](https://github.com/user-attachments/assets/282bf01b-2e1a-4e0c-bed9-b969065d79a3)

### Admin Individual Park Info Edit 
Provides a streamlined interface for administrators to edit park details.

![image](https://github.com/user-attachments/assets/4b698fa6-5942-47ff-8773-74f3cd709452)


### Server Console
Real-time logging of server communications and activities.

![image](https://github.com/user-attachments/assets/8efc20cf-2c02-41ff-8b69-93ab4a722982)


---

## 🎨 Wireframes
Explore the wireframes for Logi-Park on Figma to understand the initial design concepts and user interface layouts:

<a href="https://www.figma.com/file/example_wireframes)](https://www.figma.com/proto/KMzhhrLL60F9p9hfbatugN/UI-Day-001---Logi-Park-UI?node-id=1202-6&starting-point-node-id=1202%3A6&t=E3dSGAml68F8NSTM-1" target="_blank">View Wireframes on Figma</a>

---

## 🌟 Aspirations
The Logi-Park project aspires to:

1. **Enhance Logistics Management**:
   - Streamline operations and improve communication within logistics parks.

2. **Promote Scalability**:
   - Provide a modular design that can adapt to the evolving needs of logistics businesses.

3. **Foster Collaboration**:
   - Encourage contributions from developers worldwide to build a robust and feature-rich platform.

4. **Drive Innovation**:
   - Implement cutting-edge technologies and best practices to set new standards in logistics software solutions.

5. **Ensure Security**:
   - Prioritize user data protection and secure communication across all components.

6. **Support Sustainability**:
   - Align with the UN's Sustainable Development Goals to promote greener and healthier communities.

---

## 📜 License
This project is licensed under the [MIT License](LICENSE).

---

## ❤️ Acknowledgments
Special thanks to all contributors and testers who made this project possible. The City of Waterloo and associated stakeholders provided critical insights and support throughout the project.
