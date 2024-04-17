## Exploring_Emotions_in_VR
### Overview
The "Exploring Emotions in VR" project aims to delve into the realm of emotions within virtual reality (VR) environments. It provides a structured experience consisting of a tutorial, a baseline, and four emotional scenarios, designed to elicit specific emotional responses from users.

### Components

1. **Tutorial**: This component guides users through familiarizing themselves with the VR environment, including movements and interactions. Its purpose is to increase users' confidence in navigating the virtual space.

2. **Baseline**: Positioned between each emotional scenario, the baseline serves as a reset, allowing users to return to a neutral emotional state. 

3. **Emotional Scenarios**: Four scenarios have been developed to evoke distinct emotions: sadness, disgust, happiness, and fear. Each scenario is carefully crafted to elicit the intended emotional response.

4. **GameManager**: This component facilitates the execution of the VR experience. It controls the order and duration of scenarios, allowing for customization. By modifying the `scenarioDurations` variable in seconds, the duration of each scenario can be adjusted. Additionally, the order of scenarios can be changed by editing the `scenarioOrders` variable considering the following indexes:
   - 0: Welcome Panel
   - 1: Tutorial
   - 2: Baseline
   - 3: Sadness
   - 4: Disgust
   - 5: Happiness
   - 6: Fear
   - 7: Goodbye Panel

### Protocol

The project employs a unique protocol to guide users through the VR experience. This protocol concatenates the tutorial, baseline, and emotional scenarios according to defined timings. To initiate the protocol, start from the Welcome scene containing the GameManager object. Alternatively, individual scenarios can be run independently without time constraints by launching the respective scene.

### Getting Started

#### Prerequisites
- Oculus Quest headset (preferred)
- Oculus Link cable or Oculus Air Link enabled
- VR-ready PC

#### Setup
1. Connect your headset to your VR-ready PC.
2. Download and open the project in Unity.

#### Usage
3. Start the VR experience by running the Welcome scene, which contains the GameManager object.
4. Follow the prompts and instructions provided within the VR environment to navigate through the tutorial and emotional scenarios.
5. Customize the experience by adjusting the scenario durations and order in the GameManager component, if desired.

### Compatibility
The project has been developed and extensively tested on the Oculus Quest 2 headset. While it should theoretically work with other VR headsets, adjustments may be necessary according to the specific device used.

### Availability
At the moment, there is no standalone build available. However, we are actively working on it. In the meantime, you can download the entire project and use it in Play mode within your Unity VR development environment.

### Conclusion

"Exploring Emotions in VR" offers a unique opportunity to investigate the influence of virtual environments on human emotions. Whether for research purposes, this project provides a structured and customizable experience to engage with various emotional states within VR.

Thank you for your interest in our project!
