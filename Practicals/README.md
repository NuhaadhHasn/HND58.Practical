# WAD58 class practicals (PHP)

> **Course** Web Application Development (WAD), ICBT Kandy, batch 58 &nbsp;·&nbsp; **Year** 2023 &nbsp;·&nbsp; **Tech** PHP, no database

Seven small PHP pages from the practical sessions: a login and home page with a session, a calculator, a grade finder, a cookie counter and two array-and-cookie score keepers. Each page is one file with its form and its PHP in the same file.

<p align="center">
  <img src="screenshots/03-calculator.png" alt="Calculator" height="170">
  &nbsp;
  <img src="screenshots/05-array-print-all.png" alt="Array demo, Print All" height="170">
  &nbsp;
  <img src="screenshots/01-login.png" alt="Login" height="170">
</p>

| File | What it does |
|---|---|
| `Logging.php` | login form; the e-mail and password are written in the code (below). A good login sets a session and goes to `Home.php` |
| `Home.php` | "Welcome Nuhaadh" and a Logout button; without a session it sends you back to `Logging.php` |
| `Calc.php` | two numbers and the buttons `+ - * /` (the teacher's version is kept as a comment at the top) |
| `Grade.php` | marks for three subjects and a grade for each (A 75+, B 60+, C 50+, S 40+, F below) |
| `CookieDemo.php` | a counter kept in a cookie: **Click Me** adds one, **Reset** sets it to 0 |
| `ArrayDemo.php` | saves player names and three match scores in cookies as JSON arrays; **Print All** lists them |
| `MultiDimensionalArrayDemo.php` | the same screen, keeping the players in one array of objects (unfinished) |

## Run it

Copy the folder into `htdocs` (XAMPP/WAMP), start Apache and open `http://localhost/Practicals/Logging.php` (or any other file by name). No database is needed.

**Login:** `nuhaadh9991@gmail.com` / `nuhaadh` (in `Logging.php`).

I ran every page in a browser on PHP 8.2 (the screenshots; PHP's own warning messages were switched off for them, because they print the folder the page runs from).

## Fixed in a separate commit

The first commits hold the files as received; the fixes are their own commit. I checked each one in a browser, with PHP's warnings switched on this time:

- **`Grade.php`**: the three marks boxes now have their own names (`txtSub1`, `txtSub2`, `txtSub3`, and `txtRSub2`, `txtRSub3` for the grades). Marks of 80, 55 and 30 now give A, C and F. An empty box shows no grade, and the "Undefined array key" warnings are gone.
- **`Calc.php`**: dividing by 0 shows "You cannot divide by zero." instead of a fatal error; the numbers are checked, the starting values are set (no "Undefined variable" warnings) and the values are escaped when written back into the page.
- **`Home.php`**: the script stops (`exit`) after each redirect, so the page's content is no longer sent to a visitor who is not logged in, logout goes to `Logging.php` (the real file name) and the name is escaped. `Logging.php` also stops after its redirect and creates a new session id at login.
- **`MultiDimensionalArrayDemo.php`**: it had its own cookie name added (it shared `player` with `ArrayDemo.php`, so using one after the other gave warnings) and **Print All** printed every player twice because the same loop was there twice.

## Known issues (left as they were)

- `ArrayDemo.php` and `MultiDimensionalArrayDemo.php`: the buttons **Average Score**, **Total Score By Player** and **Total Average By Player** do nothing yet; the practicals were never finished.
- The login's e-mail and password are fixed in `Logging.php`, as in the lesson.
