# Learning period 12

I will be working together with my collegues on a Kanti school project (IDPA), we'll be creating an entire banking application including a web interface, mobile 2 factor auth, extensive backend for transactions and different accounts etc.


## 07.11
Epic: User can navigate the website and login to his banking account.
- [X] Implement /login /support (without any content/backend) according to mockups
- [X] Implement /neuanmeldung (without any content/backend) according to mockups
- [X] Implement navbar (without any content/backend) according to mockups

Unrelated:
- [X] Pick up server in Zurich

✍️ Today I was able to implement the login, support, neuamledung pages and the navbar as well. I was also able to implement simple routing however there isn't any auth needed yet as this hasnt been yet implemented in the backend. I was also able to pick up the server in Zurich without any issues :)

## 14.11

KRANK

## 21.11

Epic: User can all the important info at a quick glance on the dashboard page
- [X] Implement wealth box
- [X] Implement transactions box
- [ ] Implement chart box
- [ ] Connect frontend with backend
- [ ] Create unit & integration tests

✍️ Today I was able to implement the wealth box as well as the transactions box, I also created some new issues on which I'll be working on in the next few weeks (basically the epics in GH issue). I wasn't able to connect it to the backend yet as it's not fully implemented yet so I had to use backup data. I also wasn't able to implement charts yet but I'm very happy with how the dashboard page is looking and I was also able to make it pretty responsive. (I also made changed to the Navbar and Footer)

<img width="1729" height="970" alt="image" src="https://github.com/user-attachments/assets/537de286-09f6-4fca-917c-ad6f00400d1f" />

I also designed the email templates for the verification and the account creation. [PR here](https://github.com/reazndev/purbank-backend/pull/21)

## 28.11

Epic: User can create a transaction.
- [X] Implement transaction page (Frontend)
- [X] Implement transaction form (recipient, amount, description etc.)
- [ ] Connect frontend with backend
- [X] Implement transaction history
- [ ] Create unit & integration tests

Epic: User can see his current account balance.
- [X] Implement 'Wealth' page (Frontend)
- [ ] Connect with backend so real values are shown
- [ ] Implement showcase of all accounts with their according balance
- [ ] Create unit & integration tests

✍️ Today I was able to implement basically everything I planned for, I created the transaction page as well as the wealth page, however as the backend isnt finished yet I wasnt able to connect it so only the frontend stands with mockdata. 

## 05.12

Epic: User can see stats of his wealth/transactions etc

* [X] Showcase stats with chart library
* [X] Pie Chart (Inbound vs Outbound)
* [ ] Wealth history


* [X] Create unit tests (Data formatting for charts)
* [ ] Create integration tests

✍️ This week I integrated the chart library to show inbound vs. outbound transactions.

## 12.12

Epic: User can create new accounts

* [X] Implement account creation form (Frontend)
* [X] Connect frontend with backend
* [X] Create unit tests (Form validation)
* [ ] Create integration tests

## 19.12

Epic: Finalize connectivity and Testing

* [X] Connect "Wealth" and "Transaction" pages with backend
* [X] Implement showcase of all accounts with their according balance
* [X] Create unit tests (Balance calculation logic)
* [ ] Create integration tests

✍️ In this final session before the holidays, I finally replaced all remaining mock data with real backend calls. You can now see real account balances on the "Wealth" page and the "Transaction" history is fully dynamic. I spent the last few hours writing unit tests for the balance calculation logic to ensure the math is correct across multiple accounts. While the app is now fully functional, the integration tests remain on the "To-Do" list for January as we prioritised a working UI for the end of the year.
