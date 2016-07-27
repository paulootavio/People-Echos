
(function (angular) {
app.factory('efService', ["$http",
    function ($http) {
       
        var dataLoad = {};
         return {
            query: function () {
                return $http.get('/Facilitador/LoadFicha');
            },
            Submit: function (data, questaoCursosEDT,questaoAplicarEDT, questaoAreas) {

                return $http({
                    method: 'POST',
                    url: '/Facilitador/Cadastro',
                    data: {
                        model: data,
                        questaoCursosEDT: questaoCursosEDT,
                        questaoAplicarEDT: questaoAplicarEDT, 
                        questaoAreas: questaoAreas,
                    }
                });

            },
            getData: function () {
                
                return dataLoad;
            },
            setData: function (value) {
                dataLoad = value;
            },
            loadData: function () {
                dataLoad = $http.get('/Consultor/loadFicha');
                return true;
            }
         };
  
    }]);
})(window.angular);