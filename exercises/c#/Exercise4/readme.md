# Exercise 4
**Legacy Deployment**

Given the below system and release process
- what issues can you forsee
- what can be improved/how can these issues be mitigated

### System:
**Environments:**

**Live**
- 1 Database
- 2 VMs hosting website
- 1 load balancer

**Dev**
- 1 Database
- 1 VM hosting website

### Deployment Process:
- Use a comparison tool to compare sql
- Make a copy of every change to schema in scripts to be run against live
- Run scripts in correct order against DB
- Use load balancer to point all public traffic to 1 website and office traffic to other
- Log into VM
- Zip old code as a backup
- Copy up published code files
- Test site from office IP
- If working switch traffic and repeat to second VM
- If not revert code and cancel deployment