## Working
1. The system renders a decoy input box to the user. The content of this input box is not sent to the server
2. The users selects a date. The date is then converted to english date and updated in the hidden input date box
3. The value of the hidden element is sent to the server. The server does not have to deal with the nepali date. It just deals with english date

## Main Files

1. DateInputVc and DateInputVm: The view component renders the input boxes using the configuration provided through the Vm
2. site.js: The code to handle the changes can be found in this file


