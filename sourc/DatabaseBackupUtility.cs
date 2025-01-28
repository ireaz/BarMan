using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BarMan.sourc
{
    public static class DatabaseBackupUtility
    {
        public static void BackupDatabase(string backupFilePath)
        {
            try
            {
                // اتصال به دیتابیس
                string connectionString = "Server=localhost;Database=DbBarMan;Trusted_Connection=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // دستور T-SQL برای بکاپ‌گیری
                    string backupQuery = $@"
                        BACKUP DATABASE [DbBarMan]
                        TO DISK = '{backupFilePath}'
                        WITH FORMAT, INIT,
                        MEDIANAME = 'DbBarMan_Backup', NAME = 'Full Backup of DbBarMan';";

                    using (SqlCommand command = new SqlCommand(backupQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Backup completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during backup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public static class DatabaseRestoreUtility
    {
        public static void RestoreDatabase(string backupFilePath)
        {
            try
            {
                // اتصال به دیتابیس
                string connectionString = "Server=localhost;Database=master;Trusted_Connection=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // خاتمه دادن به اتصال‌های فعال به دیتابیس
                    string closeConnectionsQuery = @"
                        ALTER DATABASE [DbBarMan] 
                        SET SINGLE_USER 
                        WITH ROLLBACK IMMEDIATE;";

                    using (SqlCommand closeCommand = new SqlCommand(closeConnectionsQuery, connection))
                    {
                        closeCommand.ExecuteNonQuery();
                    }

                    // دستور T-SQL برای ریستور
                    string restoreQuery = $@"
                        RESTORE DATABASE [DbBarMan]
                        FROM DISK = '{backupFilePath}'
                        WITH REPLACE;";

                    using (SqlCommand restoreCommand = new SqlCommand(restoreQuery, connection))
                    {
                        restoreCommand.ExecuteNonQuery();
                    }

                    // بازگرداندن به حالت چندکاربره
                    string multiUserQuery = @"
                        ALTER DATABASE [DbBarMan] 
                        SET MULTI_USER;";

                    using (SqlCommand multiUserCommand = new SqlCommand(multiUserQuery, connection))
                    {
                        multiUserCommand.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Database restored successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during restore: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
