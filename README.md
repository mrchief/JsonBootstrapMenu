JsonBootstrapMenu
====================

Create Bootstrap (3) Menus with a simple JSON config file in ASP.NET


##Usage

Install via Nuget: [JsonBootstrapMenu](https://www.nuget.org/packages/JsonBootstrapMenu/)

##Sample

Given this config:

```js
[
  {
    "text": "Dashboard",
    "url": "/dashboard"
  },
  {
    "isDivider": true
  },
  {
    "text": "Help",
    "submenus": [
      {
        "url": "/documentation/GenHelp.pdf",
        "text": "General",
        "target": "new"
      },
      {
        "isDivider": true
      },
      {
        "url": "/documentation/DeployHelp.pdf",
        "text": "Deploy Help",
        "target": "new"
      }
    ]
  }
]
```

generates this menu structure:

```html
<ul class="nav navbar-nav">
    <li class="">
        <a href="/dashboard" target="_self">Dashboard</a>
    </li>
    <li class="dropdown">
        <a href="#" class="dropdown-toggle" data-toggle="dropdown"><span>Help</span> <b class="caret"></b></a>
        <ul class="dropdown-menu">
            <li class=""><a href="/documentation/GenHelp.pdf" target="new">General</a></li>
            <li class="divider"></li>
            <li class=""><a href="/documentation/DeployHelp.pdf" target="new">Deploy Help</a></li>
        </ul>
    </li>
</ul>
```

which looks like this when rendered*: 


![screenshot](http://i.imgur.com/R2CdujD.png)

*<sup>(note that this screenshot was generated using a custom bootstrap theme, the helper doesn't include or affect any of the bootstrap styles)</sup>
