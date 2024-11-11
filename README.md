# iRacing FOV Calculator

A user-friendly Field of View (FOV) calculator for sim racing, specifically tailored for iRacing triple-screen and single-screen setups. This application helps users calculate the optimal FOV based on their monitor setup, distance, and screen angle.

## Features

- **Single-Screen & Triple-Screen Support**: Calculates FOV for both single and triple monitor setups.
- **Adjustable Screen Parameters**: Input fields for screen width, distance to screen, screen angle, and monitor curvature.
- **Real-time Enabling of Fields**: Fields automatically enable or disable based on the chosen setup (e.g., triple vs. single).


## Requirements

- **.NET Framework 4.8**: Make sure .NET Framework 4.8 is installed. [Download .NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net48-web-installer).

## Usage

1. **Select Screen Setup**: Choose between "Single" or "Triple" screen setup.
2. **Enter Parameters**:
   - **Screen Width** (w/o bezels in mm)
   - **Distance to Screen** (in mm)
   - **Screen Angle** (in degrees, for triple screens)
   - **Monitor Curvature** (optional, for curved monitors)
3. **Calculate FOV**: Click the "Calculate FOV" button to get the optimal FOV for your setup.

## Installation

To run the application:
1. Download the latest release from the [Releases](https://github.com/azigazisipi/IracingFoVCalc/releases/tag/1.0.0) section.
2. Ensure .NET Framework 4.8 is installed on your computer.
3. Run the `iRacingFOVCalculator.exe` file to open the app.

## Changelog

### [v1.1.0] - 2024-11-11
- Refined FOV calculations for triple-screen setups with monitor angle adjustments.
- Added rounding of FOV results to nearest whole number for ease of use.
- Improved UI for FOV calculator.

### [v1.0.0] - 2024-11-11
- Initial release of iRacing FOV Calculator.
- Support for single and triple screen setups.
- Input fields for screen width, distance to screen, and screen angle.

## Development

To modify or contribute to this project:
1. Clone this repository:
   ```bash
   git clone https://github.com/azigazisipi/IracingFoVCalc
