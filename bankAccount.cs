class bankAccount
{
    double balance=0;
    double overdraftLimit;

    double interestRate;
    
    String pinNum;
    String accountNo;
    String sortCode;

    public double getBalance()
    {
        return balance;
    }
    public void deposit(double dep)
    {
        balance += dep;
    }

    public void withdraw(double with)
    {
        balance -= with;
    }
    // method to set account number
    public void setAccountNo(String acc)
    {
        this.accountNo = acc;
    }
    //method to get the account number
    public String getAccountNumber()
    {
        return accountNo;
    }    

    public void SetSortCode(String code)
    {
        this.sortCode = code;
    }
    public String getSortCode()
    {
        return sortCode;
    }

    public void setOverdraftlimit(double over)
    {
        this.overdraftLimit=over;
    }

    public double getOverdraftlimit()
    {
        return overdraftLimit;
    }

    public void setPinNumber(String Pinnumber)
    {
        this.pinNum = Pinnumber;
    }
    public String getPinNum()
    {
        return pinNum;
    }

    public void setInterestRate(int rate)
    {
        this.interestRate = rate;
    }
    public double getInterestRate()
    {
        return interestRate;
    }

}