<a name="readme-top"></a>


[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/jverwey/FileService">
    <img src="_readme/logo.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">File Service Application</h3>

  <p align="center">
    The File Service Application allows for managing files.  You can upload a single file or multiple files.  After the files upload, you may download and delete the files as needed.
    <br />
    <a href="https://github.com/jverwey/FileService"><strong>Explore the docs »</strong></a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#Future-Enhancements">Future Enhancements</a></li>
    <li><a href="#contact">Contact</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

[![Product Name Screen Shot][product-screenshot]](https://example.com)

<p>This project is built within ASP.Net Core 7.0.</p>

<p>The project architecture has an API for handling the file uploads, downloads and deletes.  The web application was built to demonstrate AJAX calls with jQuery to upload, download and delete files.</p>

<p>Additionally, for separation of concerns, there is a Business project, a Model project, and a Data project.  Architectually, the Web and API projects should never reference the Data project.</p>

<p>Implemented Interfaces initially for future enhancements.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built With

* [![ASPNetCore][ASP.Net Core]][ASPNetCore-url]
* [![Bootstrap][Bootstrap.com]][Bootstrap-url]
* [![JQuery][JQuery.com]][JQuery-url]

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple example steps.


### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/jverwey/FileService.git
   ```
2. Update the UploadFileLocation within FileService.API (appsettings.json)
3. Update the location of the database (SQLite).  Within the FileService.Data project, FileServiceContext.cs.
4. Ensure that Startup projects include both the FileService.API and FileService.Web.

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- FUTURE ENHANCEMENTS -->
## Future Enhancements

- [ ] Change the connection string to configurable.
- [ ] Implement Dependency Injection
- [ ] Implement Unit Tests and Integration Tests.
- [ ] Add a confirm dialog for "Delete" functionality.
- [ ] Implement error handling and quality error messages.
- [ ] Add logging to the application.


See the [open issues](https://github.com/jverwey/FileService/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Project Link: [https://github.com/jverwey/FileService](https://github.com/jverwey/FileService)

<p align="right">(<a href="#readme-top">back to top</a>)</p>




<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/jverwey/FileService.svg?style=for-the-badge
[contributors-url]: https://github.com/jverwey/FileService/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/jverwey/FileService.svg?style=for-the-badge
[forks-url]: https://github.com/jverwey/FileService/network/members
[stars-shield]: https://img.shields.io/github/stars/jverwey/FileService.svg?style=for-the-badge
[stars-url]: https://github.com/jverwey/FileService/stargazers
[issues-shield]: https://img.shields.io/github/issues/jverwey/FileService.svg?style=for-the-badge
[issues-url]: https://github.com/jverwey/FileService/issues
[license-shield]: https://img.shields.io/github/license/jverwey/FileService.svg?style=for-the-badge
[license-url]: https://github.com/jverwey/FileService/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/jeremy-verwey
[product-screenshot]: _readme/screenshot.png
[ASP.Net Core]: https://aspnetboilerplate.com/images/logos/tools/net-core.png
[ASPNetCore-url]: https://learn.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-7.0
[Bootstrap.com]: https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white
[Bootstrap-url]: https://getbootstrap.com
[JQuery.com]: https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white
[JQuery-url]: https://jquery.com 
