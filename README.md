# hospital_management
Yogesh Jha: Centralized Electronic Medical Record System - sarthi (v.1.06)

## Discription of SARTHI V.06 Bita version

The proposed desktop application is designed to simplify patient admission, discharge form, operation form , concent form, decleration form processes 
in a hospital setting over "Nationwide" we collaborated with "Shri Ganesh Eye Hospital - Main Road, Ranchi" to collect all information and real life exprence
with the application. 
The application is built using .NET and utilizes AWS -RDS database as its backend.
The application features a patient admission module that enables hospital staff to admit patients by capturing their personal 
information and medical history. The system generates an operation form that can be used by the medical team during the patient's surgery. 
The application also generates consent and declaration forms, which can be electronically signed by patients or their guardians.
In addition to the admission module, the application also features a patient search module that allows medical staff to search for patient 
records and access their medical history. Finally, the application includes a discharge module that enables medical staff to initiate the patient 
discharge process and generate the necessary forms.
Overall, the desktop application provides a streamlined process for patient admission, medical documentation, and discharge, which helps 
hospitals to manage patient records and provide timely and effective care.


### Table of Content

* Form1 - it is used as a welcome screen for the user ( Act as a platform to all other windows without intent new window every time)
* User - this page is to add basic details to the AWS - RDS database which can be fetch during application form, discharge form and etc without using same content again.
* Application - this is the form wher patient was first admited to the hospital, this data is being stored in "Application table"
    - Save - to save application to "Application table" in Azure Database
    - Print - to print application application in pdf format
    - reset - to clear screen while relode
* OT - this menu can be used at the  time of filling application for operation 
    - Save - to save OT application to "ot table" in Azure Database
    - Print - to print application in pdf format
    - reset - to clear screen while relode
* Discharge - this form can be used to discharge and make the patient an ImPatient of the concern hospital
    - Save - to save discharge application to "Discharge table" in Azure Database
    - Print - to print application in pdf format
    - reset - to clear screen while relode
* Concent - this menu has two main fetures one is Concent form and second one is decleration that is required before operation
    - Concent - to auto genrate data of concent
    - Decleration - to auto genrate data of declearation
* Search - this page is utlizes to find all the patient with respct to its patent id
    - Find - user with respect patent id i.e. MRD
* Help - it has basic information and version of application


## Database AWS
* Database Name: ganesh
* Table
  - User - to Add patient data (MRD is PK)
  - Application - to save application data (MRD is FK)
  - OT - to save OT application data (MRD is FK)
  - Discharge - to save Discharge application data (MRD is FK)
  - Help - To save user issues as a token 



# Installization Requirments

* OS    : win 10 or above with latest MXI
* RAM   : 2 GB or above
* GPU   : NA
* Resuation :   124 %
* Min Space :   300 MB
* Internet : Yes
* resolution : 1920 X 1080 (recommended)
* Scale View : 125% (recommended)
