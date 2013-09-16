ThrottleCode_WS
===============

This is similar to the pretty similar to the other project (AzureThrottling) except that instead of JavaScript this is written in C#. 

This tool can be used to determine what your Azure SQL DB throttling code means. 

Specifically: 
1. The throttle mode
2. The type of throttling (soft throttling vs. hard throttling).
2. The resource type (for example, CPU) due to which the throttling incident is hit.

The logic that is used is publically documented on the Microsoft website
http://msdn.microsoft.com/en-us/library/windowsazure/dn338079.aspx

