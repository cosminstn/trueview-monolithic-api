using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrueViewMonolithAPI.Authentication {
    public class FirebaseAuthManagement {

        public FirebaseApp App { get; }
        private FirebaseAuth auth;


        public FirebaseAuthManagement() {
            App = FirebaseApp.Create(new AppOptions() {
                Credential = GoogleCredential.GetApplicationDefault()
            });
            auth = FirebaseAuth.GetAuth(App);
        }


        public async Task<UserRecord> GetUserAsync(string uid) {
            return await auth.GetUserAsync(uid);
        }

        public async Task<UserRecord> GetUserByEmail(string email) {
            return await auth.GetUserByEmailAsync(email);
        }

        public async Task<FirebaseToken> VerifyIdToken(string idToken) {
            return await auth.VerifyIdTokenAsync(idToken);
        }
    }
}
