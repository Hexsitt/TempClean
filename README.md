# TempClean
A simple C# WinForms .NET Framework application that cleans Windows temporary files.

Made using Windows Forms Application (.NET Framework) with .NET Framework 4.8 base.

![](/images/print1.png)

# License

This project is licensed under the [GNU General Public License v3.0](LICENSE) - see the [LICENSE](LICENSE) file for details.

## GNU General Public License v3.0

The GNU General Public License (GPL) is a widely-used, free software license, which guarantees end users the freedom to run, study, share, and modify the software. Here's a summary of your rights and obligations under GPL v3.0:

### Your Rights

- **Use**: You are free to use the software for any purpose.
- **Study**: You can access and study how the software works, and adapt it to your needs.
- **Redistribute**: You are allowed to redistribute copies of the original software.
- **Modify**: You can make modifications to the software and distribute these modifications.

### Your Obligations

- **Share Alike**: If you modify the software and distribute it to others, you must make the source code of your modifications available under the same GPL v3.0 license.
- **Keep Copyright Notices**: You must retain any copyright notices, license, or disclaimer statements that accompany the original code.

### Restrictions

- **No Additional Restrictions**: You cannot impose any further restrictions on the recipients' exercise of the rights granted herein.
- **No Tivoization**: The license prohibits the practice of "Tivoization", which refers to the use of software that has been modified in a way that requires it to only run on a specific hardware device.

By choosing to use or distribute this software, you agree to abide by the terms of the GPL v3.0 license.

For the full text of the GNU General Public License v3.0, please see the [official GNU website](https://www.gnu.org/licenses/gpl-3.0.html).

# How to download
Go to the Releases tab and download it, you don't need to install it, just run and it will work.

* Requires .NET Framework 4.8 to run
* Windows 7 or later

**Please note**: Any antivirus alert triggered by this program is a **false positive**.


# How to build

## Requirements

* Microsoft Visual Studio 2022
  * .NET desktop development
  * Universal Windows Platform development
* Windows 10 or later

## Preparation
Download the source zip, extract it, then open the extracted folder, and open and the solution file (**TempClean.sln**) with Visual Studio.

Before building, make sure the build settings are correct. You can set the build type (debug or release) and the target platform (x86, x64, or AnyCPU) in the project settings.

![](/images/build2.png)

## Building

To build the project, go to the 'Build' menu and select 'Build Solution' (or press Ctrl + Shift + B). This will compile all project files and generate the executable.

![](/images/build1.png)

After building, check the build output in the 'Output' window of Visual Studio. This will display any errors or warnings that occurred during compilation.

After successfully building, the executable will be generated in the project's output folder. By default, this is often a subfolder such as 'bin\Debug' or 'bin\Release' within the project folder.

You can run the executable directly from Visual Studio by clicking on 'Start' or by pressing F5. Alternatively, you can navigate to the output folder and run the executable manually.

![](/images/build3.png)
