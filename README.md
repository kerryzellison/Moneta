# Moneta
[![GitHub (pre-)release](https://img.shields.io/github/release/TanayParikh/Moneta/all.svg)](https://github.com/TanayParikh/Moneta/releases)
![License](https://img.shields.io/github/license/TanayParikh/Moneta.svg)
![Status](https://img.shields.io/badge/status-beta-orange.svg)
![Author](https://img.shields.io/badge/author-Tanay%20Parikh-brightgreen.svg)
![MonetaFMS.com](https://img.shields.io/website-up-down-green-red/http/shields.io.svg?label=MonetaFMS.com)


<h1 align="center">
  <br>
  <img src="./Logo.png" alt="Moneta" width="250">
</h1>

<h4 align="center">An open source easy to use accounting solution for freelancers, no strings attached.</h4>

Moneta is a Windows 10 desktop app :computer: which supports invoicing :page_facing_up:, expenses :money_with_wings:, client management :office: and business reporting :chart_with_upwards_trend:.


## App Screenshots
<img src="./Screenshots/Dashboard.PNG" width="48%"/> <img src="./Screenshots/Invoices.PNG" width="48%"/> 

<img src="./Screenshots/Expenses.PNG" width="48%"/> <img src="./Screenshots/Clients.PNG" width="48%"/> 

<img src="./Screenshots/Invoice Items.PNG" width="48%"/> <img src="./Screenshots/Invoice Payments.PNG" width="48%"/> 

<img src="./Screenshots/Save Animation.PNG" width="48%"/> <img src="./Screenshots/Settings.PNG" width="48%"/> 


## Built With
* [Lottie UWP](https://github.com/azchohfi/LottieUWP) - Lottie Animations for UWP
* [iTextSharp-LGPL](https://github.com/schourode/iTextSharp-LGPL) - Invoice PDF Creation (Temporarily Disabled)
* [Microsoft.Data.Sqlite](https://www.asp.net) - Local DB
* [Windows Community Toolkit](https://github.com/Microsoft/WindowsCommunityToolkit) - UI Elements
* [Newtonsoft.Json](https://www.newtonsoft.com/json) - JSON Parsing
* [Bogus](https://github.com/bchavez/Bogus) - Demo Data
* [Lottie Files](https://www.lottiefiles.com) - Lottie Animations
* [Chart.js](https://www.chartjs.org) - Dashboard Charts


## Contributing

Please read [CONTRIBUTING.md](./CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.


## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/TanayParikh/Moneta/tags). 


## Authors

* **Tanay Parikh** - [Website](https://tanayparikh.com) - [GitHub](https://github.com/TanayParikh)


## License

This project is licensed under the GNU GENERAL PUBLIC LICENSE Version 3 - see the [LICENSE.md](LICENSE.md) file for details


## Scope
### Initial Scope
- [x] Rewrite core application using UWP to improve overall user experience
	- [x] Updates to core UI/UX
	- [x] Replace the portable LAMP server needed for MYSQL with SQLite
	- [x] Autoupdater - Microsoft Store
	- [x] Add support for invoice payment tracking
	- [x] Add in-app animations
	- [x] Easy invoice searching
	- [x] Add business dashboard
	- [ ] Increase overall security. 
		- [ ] Authentication on start
		- [ ] Encrypted DB
	- [ ] Add non-intrusive, privacy friendly telemetrics to further improve UX	
	- [ ] High test coverage
	- [ ] Print to PDF (`iTextSharp-LGPL` not well supported with UWP, causing following conflict)
	
```
Binary analyzer
Error Found: The binary analyzer test detected the following errors:
File iTextSharp.dll has failed the NXCheck check.
Impact if not fixed: If the app doesn???t use the available Windows protections, it can increase the vulnerability of the customer's computer to malware.
How to fix: Apply the required linker options - SAFESEH, DYNAMICBASE, NXCOMPAT, and APPCONTAINER - when you link the app. See links below for more information:
```

### Future Plans
1. Private, self-hosted server capabilities
2. **Native** cross platform support
	a. Android
	b. iOS / MacOS

## Development Notes
**Why `Decimal` over `Double`?**
https://stackoverflow.com/questions/3730019/why-not-use-double-or-float-to-represent-currency/3730040#3730040
