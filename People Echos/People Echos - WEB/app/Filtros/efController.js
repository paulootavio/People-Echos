(function (angular) {
    //FIltros
    app.controller('efcontroller', ['efService', '$scope', function (efService, $scope) {
    
        $scope.listTipoFichas = [];
        $scope.listQuestoes = [];
        $scope.isQuestoes = true;
        $scope.isVisibletableUsers = false;
        $scope.buscarResposta = buscarResposta;

       efService.LoadTipoFichas().then(function (response) {
           $scope.listTipoFichas = response.data;

           efService.LoadFichaCompleta(1, 4).then(function (response) {
               $scope.teste = response.data;
           });
           efService.listQuestoesCheck(1).then(function (response) {
               debugger;
               $scope.test2e = response.data;
           });
        
        });
             
       $scope.fcTipoFichaSelecionada = changedTipoFicha;
     
       function changedTipoFicha(ficha) {
           debugger;
           if (ficha == null) {
               $scope.isQuestoes = true;
           } else if (ficha.idAvaliacao > 0) {
               $scope.isQuestoes = false;
               buscarQuestoes(ficha.idAvaliacao)
           }
       }

       function buscarQuestoes(idtipoficha) {
           efService.Loadquestoes(idtipoficha).then(function (response) {
               $scope.listQuestoes = response.data;
           });

           efService.QuestoesChecks(idtipoficha).then(function (response) {
               debugger;
               $scope.questoesCheck = response.data;

           })
       }
       
       //function buscarQuestoesCheck(idtipoficha) {
       //    efService.listQuestoesChecks(3).then(function (response) {
       //        debugger;
       //        $scope.listQuestoesChecks = response.data;
       //    });

       //}

       function buscarResposta(idQuestao,resposta) {

           efService.LoadResposta(idQuestao, resposta).then(function (response) {
               if (response.data.length > 0) {
                   $scope.isVisibletableUsers = true;

                   $scope.listPessoas = response.data;
               }
              


           });

       }
   
    }]);

})(window.angular);

