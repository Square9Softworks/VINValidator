# VINValidator
Calculate and validate the checksum in a VIN.  Download the supported version of this Assembly from:  http://www.square-9.com/dlls/Square9.CA.VinValidate.dll

VIN:YourVIN and VINSTATUS: must be present in your GlobalCapture process fields.  Note: Theses literal values must be present as data in the field. This it not the field's name, only it's value. True or False is returned to the field containing VINSTATUS:.  VINSTATUS: is replaced with True or False in the data.  Use this value to control your document's process flow.

Vin Checksum logic based on https://github.com/dalenewman/Vin
