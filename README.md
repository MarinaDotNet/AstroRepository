#  Windows Astro Multi-Application System for Astronomical Calculations

## Overview
This system enables multiple client applications to connect to a remote server to perform astronomical calculations. The server uses a custom DLL (AstroMath.dll) that provides functions, including star velocity, star distance, temperature conversions, and black hole event horizon calculations. The system consists of four main components:
- **ServiceContract:** A .NET Console Server Application running continuously and provides calculation services over a private network. It references the **AstroMath.dll** library and communicates with clients via the Windows Communication Foundation (WCF).
- **ClientApplication:** A Windows Forms Client Application that connects to the **ServiceContract** using Named Pipes and WCF for inter-process communication. This application provides a user-friendly interface for inputting parameters and receiving calculated results.
- **AstroMath:** A custom DLL (**AstroMath.dll**) developed to perform the core astronomical calculations such as star velocity, distance, temperature conversions (Celsius to Kelvin), and black hole event horizons.
- **TestClientServiceContract:** A Console Test Client Application that verifies and tests the connection between the **ServiceContract** and the client applications. It ensures that the server-client communication is functioning correctly before deployment.

## Features
- **Server-Side Calculation Services:**
  + The server runs the **ServiceContract** console server application, which continuously provides astronomical calculations using **AstroMath.dll**.
  + **AstroMath.dll** includes the following functions:
    * Star Velocity: Calculates the velocity of stars.
    * Star Distance: Determines the distance to stars.
    * Temperature Conversion: Converts temperatures between Celsius and Kelvin.
    * Blackhole Event Horizon: Computes the event horizon of a black hole.
- **Client-Side Interface:**
  + The **ClientApplication** Windows Forms Application connects to the **ServiceContract** using Named Pipes and WCF.
  + Provides user-friendly input fields for entering parameters for astronomical calculations and read-only fields for displaying results.
  + **Scientific Output:** Outputs are formatted in scientific notation for accuracy.
- **Test Client Application:**
  + The **TestClientServiceContract** console application tests the server-client connection to ensure communication functions correctly.
  + Useful for troubleshooting and validating the system before deploying the client application.
- **Error Handling and Input Validation:**
  + The client application validates inputs to ensure they fall within the correct range for each calculation, preventing erroneous results.
- **Language Customization:**
  + The client application supports multiple languages: English (UK), French, and German.
  + Users can switch languages at runtime, and the UI updates all controls and labels accordingly.
- **UI Customization:**
  + **Night Mode:** Adjust the UI for different times of day with night mode functionality.
  + **Customizable Colours:** Users can change the background colours for forms, buttons, and text labels.
  + **Colour Dialog:** Allows users to select a custom background colour using the built-in colour dialogue.

## Technologies Used:
- **Programming Languages:** C#
- **Frameworks:** .NET Framework (Client), .NET Core (Server)
- **Libraries:** AstroMath.dll (custom third-party DLL for astronomical functions)
- **Communication:** Windows Communication Foundation (WCF), Named Pipes for inter-process communication
- **UI:** Windows Forms Application for the client interface
- **Error Handling:** Comprehensive error trapping for input validation and secure communication
 
## Screenshots
Here’s a preview of the running client application:


![Astro Client And Server App](https://github.com/user-attachments/assets/46349537-7b9e-42c0-86dd-c29ea2318902)
![Astro Client And Server App 2](https://github.com/user-attachments/assets/04c69752-63db-4ff3-a1c8-87d97c0ece46)
![Astro Dark Mode](https://github.com/user-attachments/assets/02d477d4-b25f-4e92-afab-04b76e326031)
![Astro Light Mode](https://github.com/user-attachments/assets/6d2f1cda-6bd2-47eb-8c7c-c857f066c9bb)
![Astro Adjust Colour Theme](https://github.com/user-attachments/assets/d2ccae1b-8b6b-4069-9f72-e7183b638d95)
![Astro Colour Theme](https://github.com/user-attachments/assets/116c6185-341e-4bc6-8725-c0024ad07104)
![Astro German Language](https://github.com/user-attachments/assets/3738932a-e8ba-4431-b4b7-5d72b683100b)
![Astro Franch Languge](https://github.com/user-attachments/assets/38ebcc55-f15b-4741-944f-5f21f289d1e7)
![Astro Test Client ServiceContract](https://github.com/user-attachments/assets/838fd8f3-0e74-4599-8835-c77f81f75a78)
![Astro Server App ServiceContract](https://github.com/user-attachments/assets/eddaedea-4326-4ec1-91c8-bd6ac90bd741)

