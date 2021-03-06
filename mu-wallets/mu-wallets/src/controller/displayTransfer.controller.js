﻿var transferResultCrtl = function ($stateParams,dataFactory,$q) {
    var accountNo = $stateParams.accountNo,
        accountReceive = $stateParams.accountReceive,
        amount = $stateParams.amount,
        ctrl = this;
    this.accountReceive = accountReceive;
    $q.all([
        dataFactory.Account.GetBal(accountNo),
        dataFactory.Account.GetBal(accountReceive)
    ]).then(function (response) {
        ctrl.sourceAccount = response[0].data;
        ctrl.targetAccount = response[1].data;
        });

}
transferResultCrtl.$inject = ['$stateParams', 'dataFactory','$q'];