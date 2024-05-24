**NOTE: PROJECT NO LONGER IN PRODUCTION**\
**NOTE: DB's NO LONGER LIVE**\

# GatheringForGood Readme

##General Info
The Back end of the application is based on C# Asp.Net Core.\
The main application database is in Azure, and is using Entity Framework in the app for db through code.\
While the majority of the app is .Net Core MVC, there are a number of Razor pages used for default scaffolded pages where required for the default Asp.Net Core Authenication and Authorization. These have been scaffolded for a custom appearance.\
The front end of the application uses Babel to autogenerate .js pages in wwwroot/dist, from wwwroot/js pages created using .jsx.\
Run **npx babel --watch wwwroot/js --out-dir wwwroot/dist --presets react-app/prod** when starting development.\
There are a number of nuget and npm packages used in the app.

<u>**Ensure that your ip address is added to gfg-initial DB Firewall rules in Azure before running UI test suite or interacting with database data.**</u>

## Test Accounts
**Username:** \
**Password:** \
**Email Confirmed:** Yes\
**2FA:** No\
**Lockout Enabled:** No\
**Ok in Prod:** Yes

**Username:** \
**Password:** \
**Email Confirmed:** No\
**2FA:** No\
**Lockout Enabled:** No\
**Ok in Prod:** Invalid Login Email Not Confirmed

**Username:** \
**Password:** \
**Email Confirmed:** Yes\
**2FA:** No\
**Lockout Enabled:** Yes\
**Ok in Prod:** Yes

**Username:** \
**Password:** \
**Email Confirmed:** Yes\
**2FA:** No\
**Lockout Enabled:** No\
**Ok in Prod:** Yes

**Username:** \
**Password:** \
**Email Confirmed:** No\
**2FA:** No\
**Lockout Enabled:** No\
**Ok in Prod:** Invalid Login Email Not Confirmed

**Username:** \
**Password:** \
**Email Confirmed:** Yes\
**2FA:** No\
**Lockout Enabled:** Yes\
**Ok in Prod:** Yes

**Username:** \
**Password:** \
**Note:** Do not confirm accout - Used for testing registration lockout page\
**Email Confirmed:** No\
**2FA:** No\
**Lockout Enabled:** Yes\
**Ok in Prod:** Yes

**Username:** \
**Password:** \
**Note:** Do not use for manual testing - Used to confirm GetUserActionClicks for DB\
**Email Confirmed:** Yes\
**2FA:** No\
**Lockout Enabled:** Yes\
**Ok in Prod:** Yes

##CO2e Calculations
**Reduce Meat:**
| Type          | Amount        | CO2e           |
| ------------- |:-------------:| --------------:|
| Beef          | 100g          | 22kg CO2e      |
| Lamb          | 100g          | 39.3kg CO2e    |
| Pork          | 100g          | 12.1kg CO2e    |
| Chicken       | 100g          | 6.9kg CO2e     |
| ------------- |:-------------:| --------------:|
| Average       | 100g          | 2.0075kg CO2e  |

**Plant Trees:**
| Type          | Amount        | CO2e           |
| ------------- |:-------------:| --------------:|
| 1 Tree        | per year      | 21.772kg CO2e  |

**Eat Organic:**
| Type                                           | Amount        | CO2e           |
| ---------------------------------------------- |:-------------:| --------------:|
| 7% of food emissions is supply chain transport | (2.0075/100)x7| .140525kg CO2e |

**Go Vegetarian:**
| Type                 | Amount        | CO2e           |
| -------------------- |:-------------:| --------------:|
| Average Reduce Meat  | 100g          | 2.0075kg CO2e  |

**Go Vegan:**
| Type                 | Amount        | CO2e           |
| -------------------- |:-------------:| --------------:|
| Milk                 | 200ml         | .6kg CO2e      |
| Oat Milk             | 200ml         | .18kg CO2e     |
| -------------------- |:-------------:| --------------:|
| Milk                 | 1000ml        | .3.9kg CO2e    |
| Oat Milk             | 1000ml        | .1.95kg CO2e   |
| -------------------- |:-------------:| --------------:|
| Average              | 200ml         | .39kg CO2e     |
| -------------------- |:-------------:| --------------:|
| Average Reduce Meat  | 100g          | 2.0075kg CO2e  |
| -------------------- |:-------------:| --------------:|
| Average Reduce Meat  | 200g          | 4.015kg CO2e   |
| -------------------- |:-------------:| --------------:|
| Go Vegan Total       | 200g or ml    | 4.405kg CO2e   |

**Live Car Free:**
| Type                 | Amount                    | CO2e           |
| -------------------- |:-------------------------:| --------------:|
| 1 Car                | 4.6 metric tons per year  | 4600kg CO2e    |
| 1 Car                | 1 day                     | 12.6kg CO2e    |

**Minimise Plastic:**
| Type       | Amount                       | CO2e           |
| -----------|:----------------------------:| --------------:|
| PET        | 1 pound                      | 3 pounds CO2e  |
| PET        | 1 500mm plastic water bottle | .0828kg CO2e   |

**Buy Local (See Eat Organic):**
| Type                                           | Amount        | CO2e           |
| ---------------------------------------------- |:-------------:| --------------:|
| 7% of food emissions is supply chain transport | (2.0075/100)x7| .140525kg CO2e |

**Cycle:**
Assumption: People cycling would be using a bus instead for a short journey rather than a car.
Hence the kgCO2e saving from cycling is the amount not generated by an equivalent bus journey.
| Type            | Amount        | CO2e           |
| --------------- |:-------------:| --------------:|
| 1 Bus           | Per km        | .089kg CO2e    |
| 1 Bus           | 2 km journey  | .178kg CO2e    |
| 1 Cycle Journey | 2 km journey  | .178kg CO2e    |

**Drive Electric:**
| Type                      | Amount            | CO2e           |
| ------------------------- |:-----------------:| --------------:|
| Electric Prius            | Per km            | .170kg CO2e    |
| ------------------------- |:-----------------:| --------------:|
| Avg Lifetime Use          | 150000 km         |                |
| Avg Lifetime Use          | 15000 km per yr   |                |
| Avg Lifetime Use          | 41.095890 km p/day|                |
| Avg Prius                 | p/day             | 6.986301kg CO2e|
| ------------------------- |:-----------------:| --------------:|
| Conventional Car          | Per mile          | .260kg CO2e    |
| ------------------------- |:-----------------:| --------------:|
| Avg Conventional          | p/day             | 10.68493kg CO2e|
| ------------------------- |:-----------------:| --------------:|
| Saving by switch to Prius | p/day             | 3.69863kg CO2e |

**Grow Your Own:**
| Type                      | Amount            | CO2e             |
| ------------------------- |:-----------------:| ----------------:|
| Grow vs Grocery Shopping  | saving per year   | 68lbs CO2e       |
| Grow vs Grocery Shopping  | saving per year   | 30.844kg CO2e    |
| ------------------------- |:-----------------:| ----------------:|
| Grow vs Grocery Shopping  | saving per day    | .0845041096 CO2e |

**Use Public Transport:**
| Type            | Amount        | CO2e           |
| --------------- |:-------------:| --------------:|
| 1 Car           | P/day         | 12.6kg CO2e    |
| 1 Bus           | 6.276km P/day | .558kg CO2e    |
| 1 Bus           | Saving Per day| 12.042kg CO2e  |

**Carpool:**
| Type            | Amount        | CO2e           |
| --------------- |:-------------:| --------------:|
| 1 Car w/1 pers  | P/day         | 12.6kg CO2e    |
| 1 Car w/4 pers  | P/day         | 3.115kg CO2e   |
| w/1 - w/4       | P/day         | 9.345kg CO2e   |

**Recycling (See Minimise Plastic):**
| Type       | Amount                          | CO2e           |
| -----------|:-------------------------------:| --------------:|
| PET        | 1 pound                         | 3 pounds CO2e  |
| PET        | 1 500mm plastic water bottle    | .0828kg CO2e   |
| PET x 30   | 30 x 500mm plastic water bottle | 2.484kg CO2e   |

**Insulation:**
Assumption: A once-off big job which then generates CO2e savings for 1 year.
| Type               | Amount            | CO2e           |
| ------------------ |:-----------------:| --------------:|
| 1 Insulation refit | CO2e Reduction    | 70%            |
| Average UK Home    | Tonnes p/yr       | 2700kg CO2e    |
| 1 Insulation refit | 70% CO2e Reduction| 1890kg CO2e    |

**Shorter Showers:**
| Type               | Amount            | CO2e           |
| ------------------ |:-----------------:| --------------:|
| 1 Shower           | 5min              | 1.021kg CO2e   |

**Flourescent Lightbulbs:**
| Type               | Amount            | CO2e           |
| ------------------ |:-----------------:| --------------:|
| Incandescent       | 1 bulb p/24hrs    | .186kg CO2e    |
| Flourescent        | 1 bulb p/24hrs    | .093kg CO2e    |
| Saving             | 1 bulb p/24hrs    | .093kg CO2e    |

**Turn off lights:**
| Type               | Amount            | CO2e           |
| ------------------ |:-----------------:| --------------:|
| Incandescent       | 1 bulb for 1hrs   | .00775kg CO2e  |

**Smaller Family:**
| Type           | Amount                         | CO2e           |
| -------------- |:------------------------------:| --------------:|
| UK 1995 CO2e   | 1 Person Full Lifetime         | 312000kg CO2e  |
| UK 1995 CO2e   | 1 Person Full Lifetime / 80yrs | 3900kg CO2e  |

##User Badges
**First Step** First click of any RGW, RAE, RDF\
**Gatherer for Good** 5 Shares\
**Building Back Better** 2 Actions to Promote a Green Recovery\
**Key Change Driver** 25 clicks of Reduce Meat, Vegetarian or Vegan\
**Defeat Global Warming** 100 RGW click\
**Defeat Animal Extinction** 100 RAE click\
**Defeat Deforestation** 100 RDF click\
**Deeply Care** Offset my carbon for 1 year\
**Communicating For Difference** Post 5 Articles\
**Learning for Good** Read 10 Articles\
**Making a Difference** Create 1st Initiative for Good\
**Contributor** Comment on a Newsfeed Article\
**Feedback Hero** 5 pieces of feedback on improvements to the GatheringForGood site\
**Passionate** Active for 20 Back to Back Days on GFG (To be added on a future date)\
**Helpful** Gifted by another user €5\
**Leader** Gifted by another user €20\
**Visionary** Gifted by another user €50\
**Thankyou** Gifted by another user €2\

