AzureThrottling
===============

This is pretty simple JavaScript that can be used to determine what your Azure SQL DB throttling code means. 

Specifically: 
1. The throttle mode
2. The type of throttling (soft throttling vs. hard throttling).
2. The resource type (for example, CPU) due to which the throttling incident is hit.

The logic that is used is publically documented on the Microsoft website
http://msdn.microsoft.com/en-us/library/windowsazure/dn338079.aspx

